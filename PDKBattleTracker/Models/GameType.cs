using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameType
    {
        [Key]
        [Display(Name = "Game Type ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameTypeId { get; set; }

        [Required]
        [Display(Name = "Game Type ID")]
        public string GameTypeName { get; set; }

        public List<GameGameType> GameGameTypes { get; set; }
    }
}
