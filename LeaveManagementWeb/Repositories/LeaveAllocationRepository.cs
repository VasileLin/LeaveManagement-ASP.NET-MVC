﻿using AutoMapper;
using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public LeaveAllocationRepository(ApplicationDbContext dbContext, UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
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
                .Include(q => q.LeaveType).Where(q => q.EmployeeId == employeeId).ToListAsync();
            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = _mapper.Map <List<LeaveAllocationVM>>(allocations);
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
            }
            await AddRangeAsync(allocations);

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
    }
}