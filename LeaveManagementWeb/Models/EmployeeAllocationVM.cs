using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Models
{
    public class EmployeeAllocationVM :EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
