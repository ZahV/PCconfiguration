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
    public class CdDvdsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CdDvdsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CdDvds
        public async Task<IActionResult> Index()
        {
            return View(await _context.CdDvds.ToListAsync());
        }

        // GET: CdDvds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cdDvd = await _context.CdDvds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cdDvd == null)
            {
                return NotFound();
            }

            return View(cdDvd);
        }

        // GET: CdDvds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CdDvds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price")] CdDvd cdDvd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cdDvd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cdDvd);
        }

        // GET: CdDvds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cdDvd = await _context.CdDvds.FindAsync(id);
            if (cdDvd == null)
            {
                return NotFound();
            }
            return View(cdDvd);
        }

        // POST: CdDvds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] CdDvd cdDvd)
        {
            if (id != cdDvd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cdDvd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CdDvdExists(cdDvd.Id))
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
            return View(cdDvd);
        }

        // GET: CdDvds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cdDvd = await _context.CdDvds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cdDvd == null)
            {
                return NotFound();
            }

            return View(cdDvd);
        }

        // POST: CdDvds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cdDvd = await _context.CdDvds.FindAsync(id);
            _context.CdDvds.Remove(cdDvd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CdDvdExists(int id)
        {
            return _context.CdDvds.Any(e => e.Id == id);
        }
    }
}
