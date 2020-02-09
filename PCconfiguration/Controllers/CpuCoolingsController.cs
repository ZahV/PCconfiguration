using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCconfiguration.Models;

namespace PCconfiguration.Controllers
{
    public class CpuCoolingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CpuCoolingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CpuCoolings
        public async Task<IActionResult> Index()
        {
            return View(await _context.CpuCoolings.ToListAsync());
        }

        // GET: CpuCoolings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cpuCooling = await _context.CpuCoolings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cpuCooling == null)
            {
                return NotFound();
            }

            return View(cpuCooling);
        }

        // GET: CpuCoolings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CpuCoolings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price")] CpuCooling cpuCooling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cpuCooling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cpuCooling);
        }

        // GET: CpuCoolings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cpuCooling = await _context.CpuCoolings.FindAsync(id);
            if (cpuCooling == null)
            {
                return NotFound();
            }
            return View(cpuCooling);
        }

        // POST: CpuCoolings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] CpuCooling cpuCooling)
        {
            if (id != cpuCooling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cpuCooling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CpuCoolingExists(cpuCooling.Id))
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
            return View(cpuCooling);
        }

        // GET: CpuCoolings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cpuCooling = await _context.CpuCoolings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cpuCooling == null)
            {
                return NotFound();
            }

            return View(cpuCooling);
        }

        // POST: CpuCoolings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cpuCooling = await _context.CpuCoolings.FindAsync(id);
            _context.CpuCoolings.Remove(cpuCooling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CpuCoolingExists(int id)
        {
            return _context.CpuCoolings.Any(e => e.Id == id);
        }
    }
}
