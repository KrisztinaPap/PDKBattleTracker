using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021012702 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Player1SubFaction",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player2SubFaction",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player1SubFaction",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2SubFaction",
                table: "Games");
        }
    }
}
