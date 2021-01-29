using Microsoft.EntityFrameworkCore.Migrations;

namespace PDKBattleTracker.Migrations
{
    public partial class _2021012905 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Winner",
                table: "Games",
                newName: "Player2Secondary3");

            migrationBuilder.AddColumn<string>(
                name: "Player1Custom1",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player1Custom2",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player1PrimaryRound2Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1PrimaryRound3Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1PrimaryRound4Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1PrimaryRound5Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1Secondary1Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Player1Secondary1text",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player1Secondary2",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player1Secondary2Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Player1Secondary3",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player1Secondary3Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Player2Custom1",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player2Custom2",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2PrimaryRound2Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2PrimaryRound3Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2PrimaryRound4Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2PrimaryRound5Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2Secondary1Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Player2Secondary1text",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player2Secondary2",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2Secondary2Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2Secondary3Points",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player1Custom1",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Custom2",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1PrimaryRound2Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1PrimaryRound3Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1PrimaryRound4Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1PrimaryRound5Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Secondary1Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Secondary1text",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Secondary2",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Secondary2Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Secondary3",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Secondary3Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Custom1",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Custom2",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2PrimaryRound2Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2PrimaryRound3Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2PrimaryRound4Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2PrimaryRound5Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Secondary1Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Secondary1text",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Secondary2",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Secondary2Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player2Secondary3Points",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Player2Secondary3",
                table: "Games",
                newName: "Winner");
        }
    }
}
