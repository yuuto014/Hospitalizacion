using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospitalizacion.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Longitud",
                table: "Personas",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Personas");
        }
    }
}
