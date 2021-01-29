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
    public class GameTypeController : Controller
    {
        private readonly PDKBattleTrackerContext _context;

        public GameTypeController(PDKBattleTrackerContext context)
        {
            _context = context;
        }

        // GET: GameType
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameTypes.ToListAsync());
        }

        // GET: GameType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameType = await _context.GameTypes
                .FirstOrDefaultAsync(m => m.GameTypeId == id);
            if (gameType == null)
            {
                return NotFound();
            }

            return View(gameType);
        }

        // GET: GameType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameTypeId,GameTypeName")] GameType gameType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameType);
        }

        // GET: GameType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameType = await _context.GameTypes.FindAsync(id);
            if (gameType == null)
            {
                return NotFound();
            }
            return View(gameType);
        }

        // POST: GameType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameTypeId,GameTypeName")] GameType gameType)
        {
            if (id != gameType.GameTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameTypeExists(gameType.GameTypeId))
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
            return View(gameType);
        }

        // GET: GameType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameType = await _context.GameTypes
                .FirstOrDefaultAsync(m => m.GameTypeId == id);
            if (gameType == null)
            {
                return NotFound();
            }

            return View(gameType);
        }

        // POST: GameType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameType = await _context.GameTypes.FindAsync(id);
            _context.GameTypes.Remove(gameType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameTypeExists(int id)
        {
            return _context.GameTypes.Any(e => e.GameTypeId == id);
        }
    }
}
