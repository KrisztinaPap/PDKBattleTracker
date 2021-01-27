using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDKBattleTracker.Models
{
    public class PDKBattleTrackerContext : DbContext
    {
        public PDKBattleTrackerContext (DbContextOptions<PDKBattleTrackerContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Faction> Factions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePlayer>()
                .HasKey(t => new { t.GameId, t.PlayerId });

            modelBuilder.Entity<GamePlayer>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GamePlayers)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GamePlayer>()
                .HasOne(pt => pt.Player)
                .WithMany(t => t.GamePlayers)
                .HasForeignKey(pt => pt.PlayerId);

            modelBuilder.Entity<GameFaction>()
                .HasKey(t => new { t.GameId, t.FactionId });

            modelBuilder.Entity<GameFaction>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GameFactions)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GameFaction>()
                .HasOne(pt => pt.Faction)
                .WithMany(t => t.GameFactions)
                .HasForeignKey(pt => pt.FactionId);
        }
    }
}
