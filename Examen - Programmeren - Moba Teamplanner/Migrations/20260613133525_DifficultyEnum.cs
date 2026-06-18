using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen___Programmeren___Moba_Teamplanner.Migrations
{
    /// <inheritdoc />
    public partial class DifficultyEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Champions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Champions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Types",
                table: "Champions",
                newName: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Champions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Champions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Champions",
                newName: "Types");
        }
    }
}
