using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricGamesApi.Migrations
{
    /// <inheritdoc />
    public partial class version5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Game");
        }
    }
}
