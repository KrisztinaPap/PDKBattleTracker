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
    public class GameSizeController : Controller
    {
        private readonly PDKBattleTrackerContext _context;

        public GameSizeController(PDKBattleTrackerContext context)
        {
            _context = context;
        }

        // GET: GameSize
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameSizes.ToListAsync());
        }

        // GET: GameSize/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameSize = await _context.GameSizes
                .FirstOrDefaultAsync(m => m.GameSizeId == id);
            if (gameSize == null)
            {
                return NotFound();
            }

            return View(gameSize);
        }

        // GET: GameSize/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameSize/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameSizeId,GameSizeName")] GameSize gameSize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameSize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameSize);
        }

        // GET: GameSize/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameSize = await _context.GameSizes.FindAsync(id);
            if (gameSize == null)
            {
                return NotFound();
            }
            return View(gameSize);
        }

        // POST: GameSize/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameSizeId,GameSizeName")] GameSize gameSize)
        {
            if (id != gameSize.GameSizeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameSizeExists(gameSize.GameSizeId))
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
            return View(gameSize);
        }

        // GET: GameSize/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameSize = await _context.GameSizes
                .FirstOrDefaultAsync(m => m.GameSizeId == id);
            if (gameSize == null)
            {
                return NotFound();
            }

            return View(gameSize);
        }

        // POST: GameSize/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameSize = await _context.GameSizes.FindAsync(id);
            _context.GameSizes.Remove(gameSize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameSizeExists(int id)
        {
            return _context.GameSizes.Any(e => e.GameSizeId == id);
        }
    }
}
