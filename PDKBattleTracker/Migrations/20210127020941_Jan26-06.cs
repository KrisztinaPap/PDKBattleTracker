using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class Jan2606 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FactionId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    FactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.FactionId);
                });

            migrationBuilder.CreateTable(
                name: "GameFaction",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    FactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameFaction", x => new { x.GameId, x.FactionId });
                    table.ForeignKey(
                        name: "FK_GameFaction_Factions_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Factions",
                        principalColumn: "FactionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameFaction_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameFaction_FactionId",
                table: "GameFaction",
                column: "FactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameFaction");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropColumn(
                name: "FactionId",
                table: "Games");
        }
    }
}
