﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class GameSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameSystemId { get; set; }

        [Required]
        public string GameSystemName { get; set; }

        public List<GameGameSystem> GameGameSystems { get; set; }
    }
}
