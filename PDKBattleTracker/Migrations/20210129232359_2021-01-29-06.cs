using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021012906 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player1Score",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Score",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfWins",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfWins",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "Player1Score",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2Score",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
