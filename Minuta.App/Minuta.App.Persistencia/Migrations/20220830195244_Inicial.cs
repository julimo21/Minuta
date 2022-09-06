using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "per",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numApartamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numParqueadero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Residente_celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visitante_numApartamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_per", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "veh",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "minVig",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinutaCorrespondencia_residenteid = table.Column<int>(type: "int", nullable: true),
                    tipoCorrespondencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaRecibe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firmaRecibido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutaCorrespondencia_observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anotaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    residenteid = table.Column<int>(type: "int", nullable: true),
                    MinutaVehiculoResidentes_vehiculoid = table.Column<int>(type: "int", nullable: true),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    visitanteid = table.Column<int>(type: "int", nullable: true),
                    vehiculoid = table.Column<int>(type: "int", nullable: true),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    horaSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    numParqueadero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutaVisitante_visitanteid = table.Column<int>(type: "int", nullable: true),
                    MinutaVisitante_fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MinutaVisitante_horaSalida = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minVig", x => x.id);
                    table.ForeignKey(
                        name: "FK_minVig_per_MinutaCorrespondencia_residenteid",
                        column: x => x.MinutaCorrespondencia_residenteid,
                        principalTable: "per",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVig_per_MinutaVisitante_visitanteid",
                        column: x => x.MinutaVisitante_visitanteid,
                        principalTable: "per",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVig_per_residenteid",
                        column: x => x.residenteid,
                        principalTable: "per",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVig_per_visitanteid",
                        column: x => x.visitanteid,
                        principalTable: "per",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVig_veh_MinutaVehiculoResidentes_vehiculoid",
                        column: x => x.MinutaVehiculoResidentes_vehiculoid,
                        principalTable: "veh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVig_veh_vehiculoid",
                        column: x => x.vehiculoid,
                        principalTable: "veh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_minVig_MinutaCorrespondencia_residenteid",
                table: "minVig",
                column: "MinutaCorrespondencia_residenteid");

            migrationBuilder.CreateIndex(
                name: "IX_minVig_MinutaVehiculoResidentes_vehiculoid",
                table: "minVig",
                column: "MinutaVehiculoResidentes_vehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_minVig_MinutaVisitante_visitanteid",
                table: "minVig",
                column: "MinutaVisitante_visitanteid");

            migrationBuilder.CreateIndex(
                name: "IX_minVig_residenteid",
                table: "minVig",
                column: "residenteid");

            migrationBuilder.CreateIndex(
                name: "IX_minVig_vehiculoid",
                table: "minVig",
                column: "vehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_minVig_visitanteid",
                table: "minVig",
                column: "visitanteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "minVig");

            migrationBuilder.DropTable(
                name: "per");

            migrationBuilder.DropTable(
                name: "veh");
        }
    }
}
