using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021020101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameSystemName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameSystemName",
                table: "Games");
        }
    }
}
