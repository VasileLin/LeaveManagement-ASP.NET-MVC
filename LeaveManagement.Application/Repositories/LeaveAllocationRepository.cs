using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Application.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly AutoMapper.IConfigurationProvider _configurationProvider;
        private readonly IEmailSender _emailSender;

        public LeaveAllocationRepository(ApplicationDbContext dbContext, UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper,
            AutoMapper.IConfigurationProvider configurationProvider,
            IEmailSender emailSender) : base(dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _configurationProvider = configurationProvider;
            _emailSender = emailSender;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await _dbContext.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId && 
                                                                   q.LeaveTypeId == leaveTypeId 
                                                                && q.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await _dbContext.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                .ProjectTo<LeaveAllocationVM>(_configurationProvider)
                .ToListAsync();

            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = allocations;

            return employeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
            var allocation = await _dbContext.LeaveAllocations
                .Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == id);

            if (allocation == null)
            {
                return null;
            }

            var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

            var model = _mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));
            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();
            var employeesWithNewAllocations = new List<Employee>(); 

            foreach (var employer in employees)
            {
                if (await AllocationExists(employer.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employer.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfdays = leaveType.DefaultDays
                });
                employeesWithNewAllocations.Add(employer);
            }
            await AddRangeAsync(allocations);

            foreach (var employee in employeesWithNewAllocations)
            {
                await _emailSender.SendEmailAsync(employee.Email, $"Leave allocation for {period}",
                   $"Your {leaveType.Name} has been posted for the period of {period}. You have been given {leaveType.DefaultDays} days.");
            } 

        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {

                var leaveAllocation = await GetAsync(model.Id);
                if (leaveAllocation == null)
                {
                    return false;
                }
                leaveAllocation.Period = model.Period;
                leaveAllocation.NumberOfdays = model.NumberOfDays;
                await UpdateAsync(leaveAllocation);

                return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
           return await _dbContext.LeaveAllocations.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
