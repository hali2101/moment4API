using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moment4musicAPI.Migrations
{
    /// <inheritdoc />
    public partial class Modelchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AlbumName",
                table: "Albums",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Albums",
                newName: "AlbumName");
        }
    }
}
