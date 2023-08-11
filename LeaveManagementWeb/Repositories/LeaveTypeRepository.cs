using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>,ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
