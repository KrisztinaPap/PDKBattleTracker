using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameGameSize
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int GameSizeId { get; set; }
        public GameSize GameSize { get; set; }
    }
}
