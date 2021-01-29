﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameGameType
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int GameTypeId { get; set; }
        public GameType GameType { get; set; }
    }
}
