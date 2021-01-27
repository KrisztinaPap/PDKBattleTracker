using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class SubFaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubFactionId { get; set; }
        [Required]
        public string SubFactionName { get; set; }

        public List<FactionSubFaction> FactionSubFactions { get; set; }
        public List<GameSubFaction> GameSubFactions { get; set; }
    }
}
