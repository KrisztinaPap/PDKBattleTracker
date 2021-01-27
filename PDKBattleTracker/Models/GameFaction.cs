using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameFaction
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int FactionId { get; set; }
        public Faction Faction {get; set; }
    }
}
