using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moment4musicAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOfColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Albums",
                newName: "AlbumName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlbumName",
                table: "Albums",
                newName: "CategoryName");
        }
    }
}
