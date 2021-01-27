using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameSubFaction
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int SubFactionId { get; set; }
        public SubFaction SubFaction { get; set; }
    }
}
