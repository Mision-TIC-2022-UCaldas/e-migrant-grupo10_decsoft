using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    No_Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais_origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_actual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacion_laboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Necesidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ayuda_legal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MigranteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Necesidades_Migrantes_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Migrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    juridicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viveres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comida_preparada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NecesidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_Necesidades_NecesidadId",
                        column: x => x.NecesidadId,
                        principalTable: "Necesidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Necesidades_MigranteId",
                table: "Necesidades",
                column: "MigranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_NecesidadId",
                table: "Servicio",
                column: "NecesidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Necesidades");

            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
