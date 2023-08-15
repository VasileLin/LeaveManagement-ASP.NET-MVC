using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.Repositories
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
