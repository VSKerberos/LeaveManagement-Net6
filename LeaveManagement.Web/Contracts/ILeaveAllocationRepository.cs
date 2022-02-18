using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation(int leaveTypeId);

        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string emloyeeId);

        Task<LeaveAllocation?> GetEmployeeAllocation(string emloyeeId,int leaveTypeId);

        Task<EditLeaveAllocationVM> GetEmployeeAllocation(int Id);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationVM model);


    }
}
