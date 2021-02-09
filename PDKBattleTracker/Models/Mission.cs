using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Mission ID")]
        public int MissionId { get; set; }

        [Required]
        [Display(Name = "Mission")]
        public string MissionName { get; set; }

        public List<GameMission> GameMissions { get; set; }
    }
}
