using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace escoladotnet.Migrations
{
    /// <inheritdoc />
    public partial class CompetenciaVinteSeis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "resursos",
                table: "Curso",
                newName: "recursos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "recursos",
                table: "Curso",
                newName: "resursos");
        }
    }
}
