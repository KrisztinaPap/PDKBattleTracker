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

        [Display(Name = "Game System ID")]
        public int GameSystemId { get; set; }

        [Display(Name = "Game System Name")]
        public string GameSystemName { get; set; }
        public List<GameGameSystem> GameGameSystems { get; set; }

        [Display(Name = "Game Type ID")]
        public int GameTypeId { get; set; }
        public List<GameGameType> GameGameTypes { get; set; }

        [Display(Name = "Game Size ID")]
        public int GameSizeId { get; set; }
        public List<GameGameSize> GameGameSizes { get; set; }

        [Display(Name = "Game Mission ID")]
        public int MissionId { get; set; }
        public List<GameMission> GameMissions { get; set; }

        [Display(Name = "Player ID")]
        public int PlayerId { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }

        [Display(Name = "Faction ID")]
        public int FactionId { get; set; }
        public List<GameFaction> GameFactions { get; set; }

       

        [Display(Name = "Winner")]
        public string Winner 
        {
            get {
                if (Player1Score > Player2Score)
                {
                    return Player1Name;
                }
                else if (Player2Score > Player1Score)
                {
                    return Player2Name;
                }
                else return "Tie"; 
            }
        }


        // Player 1

        [Required]
        [Display(Name = "Name")]
        public string Player1Name { get; set; }

        [Required]
        [Display(Name = "Faction")]
        public string Player1Faction { get; set; }

        [Display(Name = "Subfaction (optional)")]
        public string Player1SubFaction { get; set; }

        [Display(Name = "Custom #1 (optional)")]
        public string Player1Custom1 { get; set; }

        [Display(Name = "Custom #2 (optional)")]
        public string Player1Custom2 { get; set; }

        [Display(Name = "Round 2")]
        public int Player1PrimaryRound2Points { get; set; }

        [Display(Name = "Round 3")]
        public int Player1PrimaryRound3Points { get; set; }

        [Display(Name = "Round 4")]
        public int Player1PrimaryRound4Points { get; set; }

        [Display(Name = "Round 5")]
        public int Player1PrimaryRound5Points { get; set; }

        [Display(Name = "Secondary #1 (optional)")]
        public string Player1Secondary1text { get; set; }

        [Display(Name = "Secondary #1 Points")]
        public int Player1Secondary1Points { get; set; }

        [Display(Name = "Secondary #2 (optional)")]
        public string Player1Secondary2 { get; set; }

        [Display(Name = "Secondary #2 Points")]
        public int Player1Secondary2Points { get; set; }

        [Display(Name = "Secondary #3 (optional)")]
        public string Player1Secondary3 { get; set; }

        [Display(Name = "Secondary #3 Points")]
        public int Player1Secondary3Points { get; set; }

        [Display(Name = "Total Game Score")]
        public int Player1Score 
        { 
            get { return Player1PrimaryRound2Points + Player1PrimaryRound3Points + Player1PrimaryRound4Points + Player1PrimaryRound5Points + Player1Secondary1Points + Player1Secondary2Points + Player1Secondary3Points; } 
        }

        // Player 2

        [Required]
        [Display(Name = "Name")]
        public string Player2Name { get; set; }

        [Required]
        [Display(Name = "Faction")]
        public string Player2Faction { get; set; }

        [Display(Name = "Subfaction (optional)")]
        public string Player2SubFaction { get; set; }

        [Display(Name = "Custom #1 (optional)")]
        public string Player2Custom1 { get; set; }

        [Display(Name = "Custom #2 (optional)")]
        public string Player2Custom2 { get; set; }

        [Display(Name = "Round 2")]
        public int Player2PrimaryRound2Points { get; set; }

        [Display(Name = "Round 3")]
        public int Player2PrimaryRound3Points { get; set; }

        [Display(Name = "Round 4")]
        public int Player2PrimaryRound4Points { get; set; }

        [Display(Name = "Round 5")]
        public int Player2PrimaryRound5Points { get; set; }

        [Display(Name = "Secondary #1 (optional)")]
        public string Player2Secondary1text { get; set; }

        [Display(Name = "Secondary #1 Points")]
        public int Player2Secondary1Points { get; set; }

        [Display(Name = "Secondary #2 (optional)")]
        public string Player2Secondary2 { get; set; }

        [Display(Name = "Secondary #2 Points")]
        public int Player2Secondary2Points { get; set; }

        [Display(Name = "Secondary #3 (optional)")]
        public string Player2Secondary3 { get; set; }

        [Display(Name = "Secondary #3 Points")]
        public int Player2Secondary3Points { get; set; }

        [Display(Name = "Total Game Score")]
        public int Player2Score
        {
            get { return Player2PrimaryRound2Points + Player2PrimaryRound3Points + Player2PrimaryRound4Points + Player2PrimaryRound5Points + Player2Secondary1Points + Player2Secondary2Points + Player2Secondary3Points; }
        }


    }
}
