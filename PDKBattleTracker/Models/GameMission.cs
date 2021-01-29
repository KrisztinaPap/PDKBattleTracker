using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameMission
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int MissionId { get; set; }
        public Mission Mission { get; set; }
    }
}
