using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PDKBattleTracker.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Player ID")]
        public int PlayerId { get; set; }

        [Required]
        [Display(Name = "Player")]
        public string PlayerName { get; set; }

        [Display(Name = "Player Total Score")]
        public int PlayerTotalScore { get; set; }

        public List<GamePlayer> GamePlayers { get; set; }
    }
}
