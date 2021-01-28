using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021012801 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameSizeId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GameSizes",
                columns: table => new
                {
                    GameSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameSizeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSizes", x => x.GameSizeId);
                });

            migrationBuilder.CreateTable(
                name: "GameGameSize",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameSizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGameSize", x => new { x.GameId, x.GameSizeId });
                    table.ForeignKey(
                        name: "FK_GameGameSize_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGameSize_GameSizes_GameSizeId",
                        column: x => x.GameSizeId,
                        principalTable: "GameSizes",
                        principalColumn: "GameSizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameGameSize_GameSizeId",
                table: "GameGameSize",
                column: "GameSizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGameSize");

            migrationBuilder.DropTable(
                name: "GameSizes");

            migrationBuilder.DropColumn(
                name: "GameSizeId",
                table: "Games");
        }
    }
}
