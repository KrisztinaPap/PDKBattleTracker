﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDKBattleTracker.Models;

namespace PDKBattleTracker.Migrations
{
    [DbContext(typeof(PDKBattleTrackerContext))]
    partial class PDKBattleTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PDKBattleTracker.Models.Faction", b =>
                {
                    b.Property<int>("FactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FactionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FactionId");

                    b.ToTable("Factions");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.FactionSubFaction", b =>
                {
                    b.Property<int>("FactionId")
                        .HasColumnType("int");

                    b.Property<int>("SubFactionId")
                        .HasColumnType("int");

                    b.HasKey("FactionId", "SubFactionId");

                    b.HasIndex("SubFactionId");

                    b.ToTable("FactionSubFaction");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FactionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameSizeId")
                        .HasColumnType("int");

                    b.Property<int>("GameSystemId")
                        .HasColumnType("int");

                    b.Property<int>("GameTypeId")
                        .HasColumnType("int");

                    b.Property<int>("MissionId")
                        .HasColumnType("int");

                    b.Property<string>("Player1Faction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player1Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player1Score")
                        .HasColumnType("int");

                    b.Property<string>("Player1SubFaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player2Faction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player2Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player2Score")
                        .HasColumnType("int");

                    b.Property<string>("Player2SubFaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("SubFactionId")
                        .HasColumnType("int");

                    b.Property<string>("Winner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameFaction", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("FactionId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "FactionId");

                    b.HasIndex("FactionId");

                    b.ToTable("GameFaction");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameGameSize", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GameSizeId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GameSizeId");

                    b.HasIndex("GameSizeId");

                    b.ToTable("GameGameSize");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameGameSystem", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GameSystemId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GameSystemId");

                    b.HasIndex("GameSystemId");

                    b.ToTable("GameGameSystem");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameGameType", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GameTypeId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GameTypeId");

                    b.HasIndex("GameTypeId");

                    b.ToTable("GameGameType");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameMission", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("MissionId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("GameMission");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GamePlayer", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("GamePlayer");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameSize", b =>
                {
                    b.Property<int>("GameSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GameSizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameSizeId");

                    b.ToTable("GameSizes");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameSubFaction", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("SubFactionId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "SubFactionId");

                    b.HasIndex("SubFactionId");

                    b.ToTable("GameSubFaction");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameSystem", b =>
                {
                    b.Property<int>("GameSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GameSystemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameSystemId");

                    b.ToTable("GameSystems");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameType", b =>
                {
                    b.Property<int>("GameTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GameTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameTypeId");

                    b.ToTable("GameTypes");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerTotalScore")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.SubFaction", b =>
                {
                    b.Property<int>("SubFactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SubFactionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubFactionId");

                    b.ToTable("SubFactions");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.FactionSubFaction", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Faction", "Faction")
                        .WithMany("FactionSubFactions")
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.SubFaction", "SubFaction")
                        .WithMany("FactionSubFactions")
                        .HasForeignKey("SubFactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faction");

                    b.Navigation("SubFaction");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameFaction", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Faction", "Faction")
                        .WithMany("GameFactions")
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GameFactions")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faction");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameGameSize", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GameGameSizes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.GameSize", "GameSize")
                        .WithMany("GameGameSizes")
                        .HasForeignKey("GameSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("GameSize");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameGameSystem", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GameGameSystems")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.GameSystem", "GameSystem")
                        .WithMany("GameGameSystems")
                        .HasForeignKey("GameSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("GameSystem");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameGameType", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GameGameTypes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.GameType", "GameType")
                        .WithMany("GameGameTypes")
                        .HasForeignKey("GameTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("GameType");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameMission", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GameMissions")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.Mission", "Mission")
                        .WithMany("GameMissions")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GamePlayer", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GamePlayers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.Player", "Player")
                        .WithMany("GamePlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameSubFaction", b =>
                {
                    b.HasOne("PDKBattleTracker.Models.Game", "Game")
                        .WithMany("GameSubFactions")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDKBattleTracker.Models.SubFaction", "SubFaction")
                        .WithMany("GameSubFactions")
                        .HasForeignKey("SubFactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("SubFaction");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Faction", b =>
                {
                    b.Navigation("FactionSubFactions");

                    b.Navigation("GameFactions");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Game", b =>
                {
                    b.Navigation("GameFactions");

                    b.Navigation("GameGameSizes");

                    b.Navigation("GameGameSystems");

                    b.Navigation("GameGameTypes");

                    b.Navigation("GameMissions");

                    b.Navigation("GamePlayers");

                    b.Navigation("GameSubFactions");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameSize", b =>
                {
                    b.Navigation("GameGameSizes");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameSystem", b =>
                {
                    b.Navigation("GameGameSystems");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.GameType", b =>
                {
                    b.Navigation("GameGameTypes");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Mission", b =>
                {
                    b.Navigation("GameMissions");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Player", b =>
                {
                    b.Navigation("GamePlayers");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.SubFaction", b =>
                {
                    b.Navigation("FactionSubFactions");

                    b.Navigation("GameSubFactions");
                });
#pragma warning restore 612, 618
        }
    }
}
