﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDKBattleTracker.Models;

namespace PDKBattleTracker.Migrations
{
    [DbContext(typeof(PDKBattleTrackerContext))]
    [Migration("20210127012326_Jan26-03")]
    partial class Jan2603
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PDKBattleTracker.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Player1Faction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player1Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player1Score")
                        .HasColumnType("int");

                    b.Property<string>("Player2Faction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player2Score")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Winner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");
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

            modelBuilder.Entity("PDKBattleTracker.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerTotalScore")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
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

            modelBuilder.Entity("PDKBattleTracker.Models.Game", b =>
                {
                    b.Navigation("GamePlayers");
                });

            modelBuilder.Entity("PDKBattleTracker.Models.Player", b =>
                {
                    b.Navigation("GamePlayers");
                });
#pragma warning restore 612, 618
        }
    }
}
