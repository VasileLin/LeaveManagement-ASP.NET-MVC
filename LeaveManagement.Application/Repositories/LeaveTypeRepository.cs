using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Application.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        

        public LeaveTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task LeaveAllocation(int leaveTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
