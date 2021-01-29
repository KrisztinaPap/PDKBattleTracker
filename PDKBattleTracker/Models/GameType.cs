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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameTypeId { get; set; }

        [Required]
        public string GameTypeName { get; set; }

        public List<GameGameType> GameGameTypes { get; set; }
    }
}
