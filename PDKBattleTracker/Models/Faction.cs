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
        public int FactionId { get; set; }
        [Required]
        public string FactionName { get; set; }

        public List<GameFaction> GameFactions { get; set; }
    }
}
