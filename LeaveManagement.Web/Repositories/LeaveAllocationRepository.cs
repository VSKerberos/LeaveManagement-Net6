using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mappe;

        public LeaveAllocationRepository(ApplicationDbContext dbContext, 
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mappe ) : base(dbContext)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mappe = mappe;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await dbContext.LeaveAllocationS.AnyAsync(x => x.EmployeeId == employeeId &&
             x.LeaveTypeId == leaveTypeId && x.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string emloyeeId)
        {
            var allocations = await dbContext.LeaveAllocationS
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == emloyeeId).ToListAsync();

            var emloyee = await userManager.FindByIdAsync(emloyeeId);

            var employeeAllocationModel = mappe.Map<EmployeeAllocationVM>(emloyee);
            employeeAllocationModel.leaveAllocations = mappe.Map<List<LeaveAllocationVM>>(allocations);

            return employeeAllocationModel;
        }

        public async Task<EditLeaveAllocationVM> GetEmployeeAllocation(int Id)
        {
            var allocation = await dbContext.LeaveAllocationS
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == Id);

            if(allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

            var model = mappe.Map<EditLeaveAllocationVM>(allocation);
            model.Employee = mappe.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            var allocations = new List<LeaveAllocation>();
            foreach (var item in employees)
            {
                if (await AllocationExists(item.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = item.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
            }
            await AddRangeAsync(allocations);
            
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string emloyeeId, int leaveTypeId)
        {
            return await dbContext.LeaveAllocationS.FirstOrDefaultAsync(q=> q.EmployeeId == emloyeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
