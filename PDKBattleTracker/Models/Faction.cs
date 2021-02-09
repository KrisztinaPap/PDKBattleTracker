using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class Faction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Faction ID")]
        public int FactionId { get; set; }
        [Required]
        [Display(Name = "Faction")]
        public string FactionName { get; set; }

        public List<GameFaction> GameFactions { get; set; }
        public List<FactionSubFaction> FactionSubFactions { get; set; }
    }
}
