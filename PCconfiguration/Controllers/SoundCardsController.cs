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
    public class SoundCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SoundCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SoundCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.SoundCards.ToListAsync());
        }

        // GET: SoundCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soundCard = await _context.SoundCards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (soundCard == null)
            {
                return NotFound();
            }

            return View(soundCard);
        }

        // GET: SoundCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SoundCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price")] SoundCard soundCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(soundCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(soundCard);
        }

        // GET: SoundCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soundCard = await _context.SoundCards.FindAsync(id);
            if (soundCard == null)
            {
                return NotFound();
            }
            return View(soundCard);
        }

        // POST: SoundCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] SoundCard soundCard)
        {
            if (id != soundCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(soundCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SoundCardExists(soundCard.Id))
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
            return View(soundCard);
        }

        // GET: SoundCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soundCard = await _context.SoundCards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (soundCard == null)
            {
                return NotFound();
            }

            return View(soundCard);
        }

        // POST: SoundCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var soundCard = await _context.SoundCards.FindAsync(id);
            _context.SoundCards.Remove(soundCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SoundCardExists(int id)
        {
            return _context.SoundCards.Any(e => e.Id == id);
        }
    }
}
