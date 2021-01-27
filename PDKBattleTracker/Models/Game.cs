using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PDKBattleTracker.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display( Name = "Game Date" )]
        public DateTime GameDate { get; set; }
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }


        public string Player1Faction { get; set; }
        public string Player2Faction { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public string Winner { get; set; }

        public int PlayerId { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }
    }
}
