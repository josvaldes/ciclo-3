using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalEnCasa.App.Persistencia.Migrations
{
    public partial class Entidades16092021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Personas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NumeroTelefono",
                table: "Personas",
                newName: "celular");

            migrationBuilder.AddColumn<int>(
                name: "Identificacion",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "Personas",
                newName: "NumeroTelefono");
        }
    }
}
