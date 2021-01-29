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
    public class GameSystemController : Controller
    {
        private readonly PDKBattleTrackerContext _context;

        public GameSystemController(PDKBattleTrackerContext context)
        {
            _context = context;
        }

        // GET: GameSystem
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameSystems.ToListAsync());
        }

        // GET: GameSystem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameSystem = await _context.GameSystems
                .FirstOrDefaultAsync(m => m.GameSystemId == id);
            if (gameSystem == null)
            {
                return NotFound();
            }

            return View(gameSystem);
        }

        // GET: GameSystem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameSystem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameSystemId,GameSystemName")] GameSystem gameSystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameSystem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameSystem);
        }

        // GET: GameSystem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameSystem = await _context.GameSystems.FindAsync(id);
            if (gameSystem == null)
            {
                return NotFound();
            }
            return View(gameSystem);
        }

        // POST: GameSystem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameSystemId,GameSystemName")] GameSystem gameSystem)
        {
            if (id != gameSystem.GameSystemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameSystem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameSystemExists(gameSystem.GameSystemId))
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
            return View(gameSystem);
        }

        // GET: GameSystem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameSystem = await _context.GameSystems
                .FirstOrDefaultAsync(m => m.GameSystemId == id);
            if (gameSystem == null)
            {
                return NotFound();
            }

            return View(gameSystem);
        }

        // POST: GameSystem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameSystem = await _context.GameSystems.FindAsync(id);
            _context.GameSystems.Remove(gameSystem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameSystemExists(int id)
        {
            return _context.GameSystems.Any(e => e.GameSystemId == id);
        }
    }
}
