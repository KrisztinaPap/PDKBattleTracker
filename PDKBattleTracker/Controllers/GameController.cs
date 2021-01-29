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
    public class GameController : Controller
    {
        private readonly PDKBattleTrackerContext _context;

        public GameController(PDKBattleTrackerContext context)
        {
            _context = context;
        }

        // GET: Game
        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }

        // GET: Game/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Game/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,GameDate,GameSystemId,GameTypeId,GameSizeId,MissionId,PlayerId,FactionId,SubFactionId,Player1Name,Player1Faction,Player1SubFaction,Player1Custom1,Player1Custom2,Player1PrimaryRound2Points,Player1PrimaryRound3Points,Player1PrimaryRound4Points,Player1PrimaryRound5Points,Player1Secondary1text,Player1Secondary1Points,Player1Secondary2,Player1Secondary2Points,Player1Secondary3,Player1Secondary3Points,Player2Name,Player2Faction,Player2SubFaction,Player2Custom1,Player2Custom2,Player2PrimaryRound2Points,Player2PrimaryRound3Points,Player2PrimaryRound4Points,Player2PrimaryRound5Points,Player2Secondary1text,Player2Secondary1Points,Player2Secondary2,Player2Secondary2Points,Player2Secondary3,Player2Secondary3Points")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Game/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameId,GameDate,GameSystemId,GameTypeId,GameSizeId,MissionId,PlayerId,FactionId,SubFactionId,Player1Name,Player1Faction,Player1SubFaction,Player1Custom1,Player1Custom2,Player1PrimaryRound2Points,Player1PrimaryRound3Points,Player1PrimaryRound4Points,Player1PrimaryRound5Points,Player1Secondary1text,Player1Secondary1Points,Player1Secondary2,Player1Secondary2Points,Player1Secondary3,Player1Secondary3Points,Player2Name,Player2Faction,Player2SubFaction,Player2Custom1,Player2Custom2,Player2PrimaryRound2Points,Player2PrimaryRound3Points,Player2PrimaryRound4Points,Player2PrimaryRound5Points,Player2Secondary1text,Player2Secondary1Points,Player2Secondary2,Player2Secondary2Points,Player2Secondary3,Player2Secondary3Points")] Game game)
        {
            if (id != game.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
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
            return View(game);
        }

        // GET: Game/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }
    }
}
