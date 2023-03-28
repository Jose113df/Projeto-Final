using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace escoladotnet.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCampoConcluido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "concluido",
                table: "Curso",
                type: "bool",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "concluido",
                table: "Curso");
        }
    }
}
