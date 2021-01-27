using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PDKBattleTracker.Models
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display( Name = "Game Date" )]
        public DateTime GameDate { get; set; }
        [Required]
        public string Player1Name { get; set; }
        [Required]
        public string Player2Name { get; set; }

        [Required]
        public string Player1Faction { get; set; }
        [Required]
        public string Player2Faction { get; set; }

        public string Player1SubFaction { get; set; }
        public string Player2SubFaction { get; set; }

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public string Winner { get; set; }

        public int PlayerId { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }

        public int FactionId { get; set; }
        public List<GameFaction> GameFactions { get; set; }

        public int SubFactionId { get; set; }
        public List<GameSubFaction> GameSubFactions { get; set; }
    }
}
