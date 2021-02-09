using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameSize
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Game Size ID")]
        public int GameSizeId { get; set; }

        [Required]
        [Display(Name = "Game Size")]
        public string GameSizeName { get; set; }

        public List<GameGameSize>GameGameSizes { get; set; }
    }
}
