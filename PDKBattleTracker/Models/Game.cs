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

        public int GameSystemId { get; set; }
        public List<GameGameSystem> GameGameSystems { get; set; }

        public int GameTypeId { get; set; }
        public List<GameGameType> GameGameTypes { get; set; }

        public int GameSizeId { get; set; }
        public List<GameGameSize> GameGameSizes { get; set; }

        public int MissionId { get; set; }
        public List<GameMission> GameMissions { get; set; }

        public int PlayerId { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }

        public int FactionId { get; set; }
        public List<GameFaction> GameFactions { get; set; }

        public int SubFactionId { get; set; }
        public List<GameSubFaction> GameSubFactions { get; set; }


        // Player 1

        [Required]
        public string Player1Name { get; set; }
        [Required]
        public string Player1Faction { get; set; }
        public string Player1SubFaction { get; set; }
        public string Player1Custom1 { get; set; }
        public string Player1Custom2 { get; set; }
        public int Player1PrimaryRound2Points { get; set; }
        public int Player1PrimaryRound3Points { get; set; }
        public int Player1PrimaryRound4Points { get; set; }
        public int Player1PrimaryRound5Points { get; set; }
        public string Player1Secondary1text { get; set; }
        public int Player1Secondary1Points { get; set; }
        public string Player1Secondary2 { get; set; }
        public int Player1Secondary2Points { get; set; }
        public string Player1Secondary3 { get; set; }
        public int Player1Secondary3Points { get; set; }
        public int Player1Score 
        { 
            get { return Player1PrimaryRound2Points + Player1PrimaryRound3Points + Player1PrimaryRound4Points + Player1PrimaryRound5Points + Player1Secondary1Points + Player1Secondary2Points + Player1Secondary3Points; } 
        }

        // Player 2

        [Required]
        public string Player2Name { get; set; }
        [Required]
        public string Player2Faction { get; set; }
        public string Player2SubFaction { get; set; }
        public string Player2Custom1 { get; set; }
        public string Player2Custom2 { get; set; }
        public int Player2PrimaryRound2Points { get; set; }
        public int Player2PrimaryRound3Points { get; set; }
        public int Player2PrimaryRound4Points { get; set; }
        public int Player2PrimaryRound5Points { get; set; }
        public string Player2Secondary1text { get; set; }
        public int Player2Secondary1Points { get; set; }
        public string Player2Secondary2 { get; set; }
        public int Player2Secondary2Points { get; set; }
        public string Player2Secondary3 { get; set; }
        public int Player2Secondary3Points { get; set; }
        public int Player2Score
        {
            get { return Player2PrimaryRound2Points + Player2PrimaryRound3Points + Player2PrimaryRound4Points + Player2PrimaryRound5Points + Player2Secondary1Points + Player2Secondary2Points + Player2Secondary3Points; }
        }


    }
}
