﻿using System;
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
        public IActionResult Index()
        {
            ViewBag.GameSystemList = GetGameSystemList();
            ViewBag.GameTypeList = GetGameTypeList();
            ViewBag.GameSizeList = GetGameSizeList();
            ViewBag.MissionList = GetMissionList();
            ViewBag.PlayerList = GetPlayerList();
            ViewBag.FactionList = GetFactionList();

            List<Game> gameList = new List<Game>();
            gameList = _context.Games.ToList();
            gameList.Sort((d1, d2) => DateTime.Compare(d2.GameDate, d1.GameDate));

            return View(gameList);
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

            ViewBag.CurrentGameSystemName = GetSpecificGameSystemName(id);

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Game/Create
        public IActionResult Create()
        {
            ViewBag.GameSystemList = GetGameSystemList();
            ViewBag.GameTypeList = GetGameTypeList();
            ViewBag.GameSizeList = GetGameSizeList();
            ViewBag.MissionList = GetMissionList();
            ViewBag.PlayerList = GetPlayerList();
            ViewBag.FactionList = GetFactionList();

            return View();
        }

        // POST: Game/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,GameDate,GameSystemId,GameSystemName,GameTypeId,GameSizeId,MissionId,PlayerId,FactionId,Player1Name,Player1Faction,Player1SubFaction,Player1Custom1,Player1Custom2,Player1PrimaryRound2Points,Player1PrimaryRound3Points,Player1PrimaryRound4Points,Player1PrimaryRound5Points,Player1Secondary1text,Player1Secondary1Points,Player1Secondary2,Player1Secondary2Points,Player1Secondary3,Player1Secondary3Points,Player2Name,Player2Faction,Player2SubFaction,Player2Custom1,Player2Custom2,Player2PrimaryRound2Points,Player2PrimaryRound3Points,Player2PrimaryRound4Points,Player2PrimaryRound5Points,Player2Secondary1text,Player2Secondary1Points,Player2Secondary2,Player2Secondary2Points,Player2Secondary3,Player2Secondary3Points")] Game game)
        {
            ViewBag.GameSystemList = GetGameSystemList();
            ViewBag.GameTypeList = GetGameTypeList();
            ViewBag.GameSizeList = GetGameSizeList();
            ViewBag.MissionList = GetMissionList();
            ViewBag.PlayerList = GetPlayerList();
            ViewBag.FactionList = GetFactionList();

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
            ViewBag.GameSystemList = GetGameSystemList();
            ViewBag.GameTypeList = GetGameTypeList();
            ViewBag.GameSizeList = GetGameSizeList();
            ViewBag.MissionList = GetMissionList();
            ViewBag.PlayerList = GetPlayerList();
            ViewBag.FactionList = GetFactionList();

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("GameId,GameDate,GameSystemId,GameSystemName,GameTypeId,GameSizeId,MissionId,PlayerId,FactionId,Player1Name,Player1Faction,Player1SubFaction,Player1Custom1,Player1Custom2,Player1PrimaryRound2Points,Player1PrimaryRound3Points,Player1PrimaryRound4Points,Player1PrimaryRound5Points,Player1Secondary1text,Player1Secondary1Points,Player1Secondary2,Player1Secondary2Points,Player1Secondary3,Player1Secondary3Points,Player2Name,Player2Faction,Player2SubFaction,Player2Custom1,Player2Custom2,Player2PrimaryRound2Points,Player2PrimaryRound3Points,Player2PrimaryRound4Points,Player2PrimaryRound5Points,Player2Secondary1text,Player2Secondary1Points,Player2Secondary2,Player2Secondary2Points,Player2Secondary3,Player2Secondary3Points")] Game game)
        {
            ViewBag.GameSystemList = GetGameSystemList();
            ViewBag.GameTypeList = GetGameTypeList();
            ViewBag.GameSizeList = GetGameSizeList();
            ViewBag.MissionList = GetMissionList();
            ViewBag.PlayerList = GetPlayerList();
            ViewBag.FactionList = GetFactionList();

            if (id != game.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    _context.SaveChanges();
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

        // Get Game Systems list for dropdown
        public IEnumerable<GameSystem> GetGameSystemList()
        {
            List<GameSystem> tempGameSystemList = new List<GameSystem>();

            tempGameSystemList = (from gamesystem in _context.GameSystems select gamesystem).ToList();

            List<GameSystem> gameSystemList = new List<GameSystem>();

            foreach (GameSystem gameSystem in tempGameSystemList)
            {
                gameSystemList.Add(new GameSystem
                {
                    GameSystemId = Convert.ToInt32(gameSystem.GameSystemId),
                    GameSystemName = gameSystem.GameSystemName.ToString()
                });
            }
            return gameSystemList;
        }

        // Get Game Types list for dropdown
        public IEnumerable<GameType> GetGameTypeList()
        {
            List<GameType> tempGameTypeList = new List<GameType>();

            tempGameTypeList = (from gametype in _context.GameTypes select gametype).ToList();

            List<GameType> gameTypeList = new List<GameType>();

            foreach (GameType gameType in tempGameTypeList)
            {
                gameTypeList.Add(new GameType
                {
                    GameTypeId = Convert.ToInt32(gameType.GameTypeId),
                    GameTypeName = gameType.GameTypeName.ToString()
                });
            }
            return gameTypeList;
        }

        // Get Game Sizes list for dropdown
        public IEnumerable<GameSize> GetGameSizeList()
        {
            List<GameSize> tempGameSizeList = new List<GameSize>();

            tempGameSizeList = (from gamesize in _context.GameSizes select gamesize).ToList();

            List<GameSize> gameSizeList = new List<GameSize>();

            foreach (GameSize gameSize in tempGameSizeList)
            {
                gameSizeList.Add(new GameSize
                {
                    GameSizeId = Convert.ToInt32(gameSize.GameSizeId),
                    GameSizeName = gameSize.GameSizeName.ToString()
                });
            }
            return gameSizeList;
        }

        // Get Missions list for dropdown
        public IEnumerable<Mission> GetMissionList()
        {
            List<Mission> tempMissionList = new List<Mission>();

            tempMissionList = (from mission in _context.Missions select mission).ToList();

            tempMissionList = tempMissionList.OrderBy(o => o.MissionName).ToList();

            List<Mission> missionList = new List<Mission>();

            foreach (Mission mission in tempMissionList)
            {
                missionList.Add(new Mission
                {
                    MissionId = Convert.ToInt32(mission.MissionId),
                    MissionName = mission.MissionName.ToString()
                });
            }
            return missionList;
        }

        // Get Players list for dropdown
        public IEnumerable<Player> GetPlayerList()
        {
            List<Player> tempPlayerList = new List<Player>();

            tempPlayerList = (from player in _context.Players select player).ToList();

            tempPlayerList = tempPlayerList.OrderBy(o => o.PlayerName).ToList();

            List<Player> playerList = new List<Player>();

            foreach (Player player in tempPlayerList)
            {
                playerList.Add(new Player
                {
                    PlayerId = Convert.ToInt32(player.PlayerId),
                    PlayerName = player.PlayerName.ToString()
                });
            }
            return playerList;
        }


        // Get Factions list for dropdown
        public IEnumerable<Faction> GetFactionList()
        {
            List<Faction> tempFactionList = new List<Faction>();

            tempFactionList = (from faction in _context.Factions select faction).ToList();

            tempFactionList = tempFactionList.OrderBy(o => o.FactionName).ToList();

            List<Faction> factionList = new List<Faction>();

            foreach (Faction faction in tempFactionList)
            {
                factionList.Add(new Faction
                {
                    FactionId = Convert.ToInt32(faction.FactionId),
                    FactionName = faction.FactionName.ToString()
                });
            }
         
            return factionList;
        }


        // Get Current Game info
        public string GetSpecificGameSystemName(int? id)
        {
            var currentGameSystemName = _context.GameSystems.Where(m => m.GameSystemId == id).Select(m => m.GameSystemName).ToString();

            return currentGameSystemName;
        }

    }
}
