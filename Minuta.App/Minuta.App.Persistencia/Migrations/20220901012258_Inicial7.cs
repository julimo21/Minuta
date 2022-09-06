using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVig_per_MinutaCorrespondencia_residenteid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_per_MinutaVisitante_visitanteid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_per_residenteid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_per_visitanteid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_MinutaVehiculoResidentes_vehiculoid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_vehiculoid",
                table: "minVig");

            migrationBuilder.DropPrimaryKey(
                name: "PK_per",
                table: "per");

            migrationBuilder.DropPrimaryKey(
                name: "PK_minVig",
                table: "minVig");

            migrationBuilder.DropIndex(
                name: "IX_minVig_MinutaCorrespondencia_residenteid",
                table: "minVig");

            migrationBuilder.DropIndex(
                name: "IX_minVig_MinutaVehiculoResidentes_vehiculoid",
                table: "minVig");

            migrationBuilder.DropIndex(
                name: "IX_minVig_MinutaVisitante_visitanteid",
                table: "minVig");

            migrationBuilder.DropIndex(
                name: "IX_minVig_residenteid",
                table: "minVig");

            migrationBuilder.DropIndex(
                name: "IX_minVig_vehiculoid",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "MinutaCorrespondencia_observaciones",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "MinutaCorrespondencia_residenteid",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "MinutaVehiculoResidentes_vehiculoid",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "MinutaVisitante_fechaSalida",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "MinutaVisitante_horaSalida",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "MinutaVisitante_visitanteid",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "anotaciones",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "firmaRecibido",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "numParqueadero",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "observaciones",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "personaEntrega",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "personaRecibe",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "residenteid",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "tipoCorrespondencia",
                table: "minVig");

            migrationBuilder.DropColumn(
                name: "vehiculoid",
                table: "minVig");

            migrationBuilder.RenameTable(
                name: "per",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "minVig",
                newName: "minVis");

            migrationBuilder.RenameColumn(
                name: "Visitante_numApartamento",
                table: "Persona",
                newName: "usuario");

            migrationBuilder.RenameIndex(
                name: "IX_minVig_visitanteid",
                table: "minVis",
                newName: "IX_minVis_visitanteid");

            migrationBuilder.AlterColumn<string>(
                name: "numApartamento",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residente_contrasena",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residente_usuario",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vigilante_contrasena",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vigilante_usuario",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contrasena",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "horaSalida",
                table: "minVis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaSalida",
                table: "minVis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_minVis",
                table: "minVis",
                column: "id");

            migrationBuilder.CreateTable(
                name: "minCor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    residenteid = table.Column<int>(type: "int", nullable: true),
                    tipoCorrespondencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personaEntrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personaRecibe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firmaRecibido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minCor", x => x.id);
                    table.ForeignKey(
                        name: "FK_minCor_Persona_residenteid",
                        column: x => x.residenteid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "minEve",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anotaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minEve", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "minVehRes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    residenteid = table.Column<int>(type: "int", nullable: true),
                    vehiculoid = table.Column<int>(type: "int", nullable: true),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minVehRes", x => x.id);
                    table.ForeignKey(
                        name: "FK_minVehRes_Persona_residenteid",
                        column: x => x.residenteid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVehRes_veh_vehiculoid",
                        column: x => x.vehiculoid,
                        principalTable: "veh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "minVehVis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitanteid = table.Column<int>(type: "int", nullable: true),
                    vehiculoid = table.Column<int>(type: "int", nullable: true),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numParqueadero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minVehVis", x => x.id);
                    table.ForeignKey(
                        name: "FK_minVehVis_Persona_visitanteid",
                        column: x => x.visitanteid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVehVis_veh_vehiculoid",
                        column: x => x.vehiculoid,
                        principalTable: "veh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_minCor_residenteid",
                table: "minCor",
                column: "residenteid");

            migrationBuilder.CreateIndex(
                name: "IX_minVehRes_residenteid",
                table: "minVehRes",
                column: "residenteid");

            migrationBuilder.CreateIndex(
                name: "IX_minVehRes_vehiculoid",
                table: "minVehRes",
                column: "vehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_minVehVis_vehiculoid",
                table: "minVehVis",
                column: "vehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_minVehVis_visitanteid",
                table: "minVehVis",
                column: "visitanteid");

            migrationBuilder.AddForeignKey(
                name: "FK_minVis_Persona_visitanteid",
                table: "minVis",
                column: "visitanteid",
                principalTable: "Persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVis_Persona_visitanteid",
                table: "minVis");

            migrationBuilder.DropTable(
                name: "minCor");

            migrationBuilder.DropTable(
                name: "minEve");

            migrationBuilder.DropTable(
                name: "minVehRes");

            migrationBuilder.DropTable(
                name: "minVehVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_minVis",
                table: "minVis");

            migrationBuilder.DropColumn(
                name: "Residente_contrasena",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Residente_usuario",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Vigilante_contrasena",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Vigilante_usuario",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "contrasena",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "per");

            migrationBuilder.RenameTable(
                name: "minVis",
                newName: "minVig");

            migrationBuilder.RenameColumn(
                name: "usuario",
                table: "per",
                newName: "Visitante_numApartamento");

            migrationBuilder.RenameIndex(
                name: "IX_minVis_visitanteid",
                table: "minVig",
                newName: "IX_minVig_visitanteid");

            migrationBuilder.AlterColumn<string>(
                name: "numApartamento",
                table: "per",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "horaSalida",
                table: "minVig",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaSalida",
                table: "minVig",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MinutaCorrespondencia_observaciones",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinutaCorrespondencia_residenteid",
                table: "minVig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinutaVehiculoResidentes_vehiculoid",
                table: "minVig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MinutaVisitante_fechaSalida",
                table: "minVig",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MinutaVisitante_horaSalida",
                table: "minVig",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinutaVisitante_visitanteid",
                table: "minVig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "anotaciones",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firmaRecibido",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numParqueadero",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observaciones",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "personaEntrega",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "personaRecibe",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "residenteid",
                table: "minVig",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipoCorrespondencia",
                table: "minVig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vehiculoid",
                table: "minVig",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_per",
                table: "per",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_minVig",
                table: "minVig",
                column: "id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_MinutaCorrespondencia_residenteid",
                table: "minVig",
                column: "MinutaCorrespondencia_residenteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_MinutaVisitante_visitanteid",
                table: "minVig",
                column: "MinutaVisitante_visitanteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_residenteid",
                table: "minVig",
                column: "residenteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_visitanteid",
                table: "minVig",
                column: "visitanteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_MinutaVehiculoResidentes_vehiculoid",
                table: "minVig",
                column: "MinutaVehiculoResidentes_vehiculoid",
                principalTable: "veh",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoid",
                table: "minVig",
                column: "vehiculoid",
                principalTable: "veh",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
