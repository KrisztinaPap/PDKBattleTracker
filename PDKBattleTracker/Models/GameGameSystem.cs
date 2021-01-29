using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameGameSystem
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int GameSystemId { get; set; }
        public GameSystem GameSystem { get; set; }
    }
}
