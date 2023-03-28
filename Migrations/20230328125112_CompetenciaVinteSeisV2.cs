using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace escoladotnet.Migrations
{
    /// <inheritdoc />
    public partial class CompetenciaVinteSeisV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prazo",
                table: "Curso",
                newName: "prazo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Curso",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "prazo",
                table: "Curso",
                newName: "Prazo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Curso",
                newName: "Id");
        }
    }
}
