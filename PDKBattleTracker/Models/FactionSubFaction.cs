using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class FactionSubFaction
    {
        public int FactionId { get; set; }
        public Faction Faction { get; set; }
        public int SubFactionId { get; set; }
        public SubFaction SubFaction { get; set; }
    }
}
