#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using AutoMapper;


namespace LeaveManagement.Web.Controllers
{
    public class LeaveTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public LeaveTypesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: LeaveType
        public async Task<IActionResult> Index()
        {
            var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await _context.LeaveTypes.ToListAsync());
            return View(leaveTypes);
        }

        // GET: LeaveType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveTypes = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveTypes == null)
            {
                return NotFound();
            }

            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveTypes);
            return View(leaveTypeVM);
        }

        // GET: LeaveType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveTypes>(leaveTypeVM);
                _context.Add(leaveType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveTypes = await _context.LeaveTypes.FindAsync(id);
            if (leaveTypes == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveTypes);
            return View(leaveTypeVM);
        }

        // POST: LeaveType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveTypes>(leaveTypeVM);
                    _context.Update(leaveType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypesExists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveTypes = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveTypes == null)
            {
                return NotFound();
            }

            return View(leaveTypes);
        }

        // POST: LeaveType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveTypes = await _context.LeaveTypes.FindAsync(id);
            _context.LeaveTypes.Remove(leaveTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveTypesExists(int id)
        {
            return _context.LeaveTypes.Any(e => e.Id == id);
        }
    }
}
