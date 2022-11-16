using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricGamesApi.Migrations
{
    /// <inheritdoc />
    public partial class version6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InGameImage1",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "InGameImage2",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "InGameImage3",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "InGameImage4",
                table: "Game");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InGameImage1",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InGameImage2",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InGameImage3",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InGameImage4",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
