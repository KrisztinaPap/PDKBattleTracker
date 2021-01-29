using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDKBattleTracker.Models;

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
        public DbSet<SubFaction> SubFactions { get; set; }
        public DbSet<GameSize> GameSizes { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<GameSystem> GameSystems { get; set; }

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

          
            modelBuilder.Entity<GameSubFaction>()
               .HasKey(t => new { t.GameId, t.SubFactionId });

            modelBuilder.Entity<GameSubFaction>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GameSubFactions)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GameSubFaction>()
                .HasOne(pt => pt.SubFaction)
                .WithMany(t => t.GameSubFactions)
                .HasForeignKey(pt => pt.SubFactionId);

           
            modelBuilder.Entity<FactionSubFaction>()
              .HasKey(t => new { t.FactionId, t.SubFactionId });

            modelBuilder.Entity<FactionSubFaction>()
                .HasOne(pt => pt.Faction)
                .WithMany(p => p.FactionSubFactions)
                .HasForeignKey(pt => pt.FactionId);

            modelBuilder.Entity<FactionSubFaction>()
                .HasOne(pt => pt.SubFaction)
                .WithMany(t => t.FactionSubFactions)
                .HasForeignKey(pt => pt.SubFactionId);

            
            modelBuilder.Entity<GameGameSize>()
             .HasKey(t => new { t.GameId, t.GameSizeId });

            modelBuilder.Entity<GameGameSize>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GameGameSizes)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GameGameSize>()
                .HasOne(pt => pt.GameSize)
                .WithMany(t => t.GameGameSizes)
                .HasForeignKey(pt => pt.GameSizeId);


            modelBuilder.Entity<GameMission>()
                .HasKey(t => new { t.GameId, t.MissionId });

            modelBuilder.Entity<GameMission>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GameMissions)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GameMission>()
                .HasOne(pt => pt.Mission)
                .WithMany(t => t.GameMissions)
                .HasForeignKey(pt => pt.MissionId);


            modelBuilder.Entity<GameGameType>()
               .HasKey(t => new { t.GameId, t.GameTypeId });

            modelBuilder.Entity<GameGameType>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GameGameTypes)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GameGameType>()
                .HasOne(pt => pt.GameType)
                .WithMany(t => t.GameGameTypes)
                .HasForeignKey(pt => pt.GameTypeId);


            modelBuilder.Entity<GameGameSystem>()
           .HasKey(t => new { t.GameId, t.GameSystemId });

            modelBuilder.Entity<GameGameSystem>()
                .HasOne(pt => pt.Game)
                .WithMany(p => p.GameGameSystems)
                .HasForeignKey(pt => pt.GameId);

            modelBuilder.Entity<GameGameSystem>()
                .HasOne(pt => pt.GameSystem)
                .WithMany(t => t.GameGameSystems)
                .HasForeignKey(pt => pt.GameSystemId);
        }
    }
}
