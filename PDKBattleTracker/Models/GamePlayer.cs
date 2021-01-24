using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GamePlayer
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
