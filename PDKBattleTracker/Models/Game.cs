using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PDKBattleTracker.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public DateTime GameDate { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public string Player1Faction { get; set; }
        public string Player2Faction { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public string Winner { get; set; }

        public List<Player> Players { get; } = new List<Player>();
    }
}
