using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricGamesApi.Migrations
{
    /// <inheritdoc />
    public partial class version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Game",
                newName: "InGameImage4");

            migrationBuilder.AddColumn<string>(
                name: "HeroImage",
                table: "Game",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeroImage",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "InGameImage1",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "InGameImage2",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "InGameImage3",
                table: "Game");

            migrationBuilder.RenameColumn(
                name: "InGameImage4",
                table: "Game",
                newName: "Image");
        }
    }
}
