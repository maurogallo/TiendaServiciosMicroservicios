using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaServicios.Api.Autor.Migrations
{
    public partial class MigracionPostgresInicialguid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "GradoAcademicoGuid",
                table: "GradoAcademico",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorLibroGuid",
                table: "AutorLibro",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GradoAcademicoGuid",
                table: "GradoAcademico",
                type: "text",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "AutorLibroGuid",
                table: "AutorLibro",
                type: "text",
                nullable: true,
                oldClrType: typeof(Guid));
        }
    }
}
