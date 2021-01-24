using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class PDKBattleTrackerContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=battletracker.db");
    }
}
