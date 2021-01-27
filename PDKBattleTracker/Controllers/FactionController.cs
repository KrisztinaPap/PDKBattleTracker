using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PDKBattleTracker.Models;

namespace PDKBattleTracker.Controllers
{
    public class FactionController : Controller
    {
        private readonly PDKBattleTrackerContext _context;

        public FactionController(PDKBattleTrackerContext context)
        {
            _context = context;
        }

        // GET: Faction
        public async Task<IActionResult> Index()
        {
            return View(await _context.Factions.ToListAsync());
        }

        // GET: Faction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faction = await _context.Factions
                .FirstOrDefaultAsync(m => m.FactionId == id);
            if (faction == null)
            {
                return NotFound();
            }

            return View(faction);
        }

        // GET: Faction/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FactionId,FactionName")] Faction faction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faction);
        }

        // GET: Faction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faction = await _context.Factions.FindAsync(id);
            if (faction == null)
            {
                return NotFound();
            }
            return View(faction);
        }

        // POST: Faction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FactionId,FactionName")] Faction faction)
        {
            if (id != faction.FactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactionExists(faction.FactionId))
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
            return View(faction);
        }

        // GET: Faction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faction = await _context.Factions
                .FirstOrDefaultAsync(m => m.FactionId == id);
            if (faction == null)
            {
                return NotFound();
            }

            return View(faction);
        }

        // POST: Faction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faction = await _context.Factions.FindAsync(id);
            _context.Factions.Remove(faction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactionExists(int id)
        {
            return _context.Factions.Any(e => e.FactionId == id);
        }
    }
}
