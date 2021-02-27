using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021022701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FactionSubFaction");

            migrationBuilder.DropTable(
                name: "GameSubFaction");

            migrationBuilder.DropTable(
                name: "SubFactions");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "SubFactionId",
                table: "Games");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SubFactionId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SubFactions",
                columns: table => new
                {
                    SubFactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubFactionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubFactions", x => x.SubFactionId);
                });

            migrationBuilder.CreateTable(
                name: "FactionSubFaction",
                columns: table => new
                {
                    FactionId = table.Column<int>(type: "int", nullable: false),
                    SubFactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactionSubFaction", x => new { x.FactionId, x.SubFactionId });
                    table.ForeignKey(
                        name: "FK_FactionSubFaction_Factions_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Factions",
                        principalColumn: "FactionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactionSubFaction_SubFactions_SubFactionId",
                        column: x => x.SubFactionId,
                        principalTable: "SubFactions",
                        principalColumn: "SubFactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameSubFaction",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    SubFactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSubFaction", x => new { x.GameId, x.SubFactionId });
                    table.ForeignKey(
                        name: "FK_GameSubFaction_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameSubFaction_SubFactions_SubFactionId",
                        column: x => x.SubFactionId,
                        principalTable: "SubFactions",
                        principalColumn: "SubFactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactionSubFaction_SubFactionId",
                table: "FactionSubFaction",
                column: "SubFactionId");

            migrationBuilder.CreateIndex(
                name: "IX_GameSubFaction_SubFactionId",
                table: "GameSubFaction",
                column: "SubFactionId");
        }
    }
}
