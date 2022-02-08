namespace LeaveManagement.Web.Models
{
    public class EditLeaveAllocationVM : LeaveAllocationVM
    {
        public string EmployeeId { get; set; }

        public int LeaveTypeId { get; set; }

        public EmployeeListVM? Employee { get; set; }
    }
}
