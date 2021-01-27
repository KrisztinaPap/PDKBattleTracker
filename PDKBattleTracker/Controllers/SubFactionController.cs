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
    public class SubFactionController : Controller
    {
        private readonly PDKBattleTrackerContext _context;

        public SubFactionController(PDKBattleTrackerContext context)
        {
            _context = context;
        }

        // GET: SubFaction
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubFactions.ToListAsync());
        }

        // GET: SubFaction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subFaction = await _context.SubFactions
                .FirstOrDefaultAsync(m => m.SubFactionId == id);
            if (subFaction == null)
            {
                return NotFound();
            }

            return View(subFaction);
        }

        // GET: SubFaction/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubFaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubFactionId,SubFactionName")] SubFaction subFaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subFaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subFaction);
        }

        // GET: SubFaction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subFaction = await _context.SubFactions.FindAsync(id);
            if (subFaction == null)
            {
                return NotFound();
            }
            return View(subFaction);
        }

        // POST: SubFaction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubFactionId,SubFactionName")] SubFaction subFaction)
        {
            if (id != subFaction.SubFactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subFaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubFactionExists(subFaction.SubFactionId))
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
            return View(subFaction);
        }

        // GET: SubFaction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subFaction = await _context.SubFactions
                .FirstOrDefaultAsync(m => m.SubFactionId == id);
            if (subFaction == null)
            {
                return NotFound();
            }

            return View(subFaction);
        }

        // POST: SubFaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subFaction = await _context.SubFactions.FindAsync(id);
            _context.SubFactions.Remove(subFaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubFactionExists(int id)
        {
            return _context.SubFactions.Any(e => e.SubFactionId == id);
        }
    }
}
