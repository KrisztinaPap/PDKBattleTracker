using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021012903 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameMission_Mission_MissionId",
                table: "GameMission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mission",
                table: "Mission");

            migrationBuilder.RenameTable(
                name: "Mission",
                newName: "Missions");

            migrationBuilder.AddColumn<int>(
                name: "GameTypeId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Missions",
                table: "Missions",
                column: "MissionId");

            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.GameTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GameGameType",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGameType", x => new { x.GameId, x.GameTypeId });
                    table.ForeignKey(
                        name: "FK_GameGameType_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGameType_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "GameTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameGameType_GameTypeId",
                table: "GameGameType",
                column: "GameTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameMission_Missions_MissionId",
                table: "GameMission",
                column: "MissionId",
                principalTable: "Missions",
                principalColumn: "MissionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameMission_Missions_MissionId",
                table: "GameMission");

            migrationBuilder.DropTable(
                name: "GameGameType");

            migrationBuilder.DropTable(
                name: "GameTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Missions",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "GameTypeId",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Missions",
                newName: "Mission");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mission",
                table: "Mission",
                column: "MissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameMission_Mission_MissionId",
                table: "GameMission",
                column: "MissionId",
                principalTable: "Mission",
                principalColumn: "MissionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
