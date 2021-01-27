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
            ViewBag.PlayerList = GetPlayerlist();
            ViewBag.FactionList = GetFactionList();
            ViewBag.SubFactionList = GetSubFactionList();

            return View(await _context.Games.ToListAsync());
        }

        [HttpPost]
        public IActionResult Index(string PlayerId, string PlayerName, string FactionId, string FactionName, string SubFactionId, string SubFactionName)
        {
            ViewBag.PlayerList = GetPlayerlist();
            ViewBag.FactionList = GetFactionList();
            ViewBag.SubFactionList = GetSubFactionList();

            return View();
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
            ViewBag.PlayerList = GetPlayerlist();
            ViewBag.FactionList = GetFactionList();
            ViewBag.SubFactionList = GetSubFactionList();

            return View();
        }

        // POST: Game/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,GameDate,Player1Name,Player2Name,Player1Faction,Player2Faction,Player1SubFaction, Player2SubFaction,Player1Score,Player2Score,Winner")] Game game)
        {
            ViewBag.PlayerList = GetPlayerlist();
            ViewBag.FactionList = GetFactionList();
            ViewBag.SubFactionList = GetSubFactionList();

            if (ModelState.IsValid)
            {
                // Adding player 1's score to their total score

                Player currentPlayer1 = new Player();
                currentPlayer1 = await _context.Players
                    .FirstOrDefaultAsync(m => m.PlayerName == game.Player1Name);
                var updatedScore1 = currentPlayer1.PlayerTotalScore + game.Player1Score;
                currentPlayer1.PlayerTotalScore = updatedScore1;

                // Adding player 2's score to their total score

                Player currentPlayer2 = new Player();
                currentPlayer2 = await _context.Players
                    .FirstOrDefaultAsync(m => m.PlayerName == game.Player2Name);
                var updatedScore2 = currentPlayer2.PlayerTotalScore + game.Player2Score;
                currentPlayer2.PlayerTotalScore = updatedScore2;

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
        public async Task<IActionResult> Edit(int id, [Bind("GameId,GameDate,Player1Name,Player2Name,Player1Faction,Player2Faction,Player1Score,Player2Score,Winner")] Game game)
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

        // Create the player dropdown list
        public IEnumerable<Player> GetPlayerlist() {

            List<Player> tempPlayerList = new List<Player>();

            tempPlayerList = (from player in _context.Players select player).ToList();

            List<Player> playerList = new List<Player>();

            foreach(Player player in tempPlayerList)
            {
                playerList.Add(new Player
                {
                    PlayerId = Convert.ToInt32(player.PlayerId),
                    PlayerName = player.PlayerName.ToString(),
                    PlayerTotalScore = Convert.ToInt32(player.PlayerTotalScore)
                });
            }
     
            return playerList;
        }

        // Create the faction dropdown list
        public IEnumerable<Faction> GetFactionList()
        {
            List<Faction> tempFactionList = new List<Faction>();

            tempFactionList = (from faction in _context.Factions select faction).ToList();

            List<Faction> factionList = new List<Faction>();

            foreach(Faction faction in tempFactionList)
            {
                factionList.Add(new Faction
                {
                    FactionId = Convert.ToInt32(faction.FactionId),
                    FactionName = faction.FactionName.ToString()
                });
            }

            return factionList;
        }

        // Create the subfaction dropdown list

        public IEnumerable<SubFaction> GetSubFactionList()
        {
            List<SubFaction> tempSubFactionList = new List<SubFaction>();

            tempSubFactionList = (from subfaction in _context.SubFactions select subfaction).ToList();

            List<SubFaction> subFactionList = new List<SubFaction>();

            foreach (SubFaction subfaction in tempSubFactionList)
            {
                subFactionList.Add(new SubFaction
                {
                    SubFactionId = Convert.ToInt32(subfaction.SubFactionId),
                    SubFactionName = subfaction.SubFactionName.ToString()
                });
            }

            return subFactionList;
        }
    }
}
