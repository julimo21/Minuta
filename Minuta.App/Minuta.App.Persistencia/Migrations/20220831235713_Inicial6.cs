using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVis_vis_visitanteid",
                table: "minVis");

            migrationBuilder.DropTable(
                name: "adm");

            migrationBuilder.DropTable(
                name: "minCor");

            migrationBuilder.DropTable(
                name: "minEve");

            migrationBuilder.DropTable(
                name: "minVehRes");

            migrationBuilder.DropTable(
                name: "minVehVis");

            migrationBuilder.DropTable(
                name: "vig");

            migrationBuilder.DropTable(
                name: "res");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vis",
                table: "vis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_minVis",
                table: "minVis");

            migrationBuilder.RenameTable(
                name: "vis",
                newName: "per");

            migrationBuilder.RenameTable(
                name: "minVis",
                newName: "minVig");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "per",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Residente_celular",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Visitante_numApartamento",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "celular",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "empresa",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numParqueadero",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "turno",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "per");

            migrationBuilder.DropColumn(
                name: "Residente_celular",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Visitante_numApartamento",
                table: "per");

            migrationBuilder.DropColumn(
                name: "celular",
                table: "per");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "per");

            migrationBuilder.DropColumn(
                name: "empresa",
                table: "per");

            migrationBuilder.DropColumn(
                name: "numParqueadero",
                table: "per");

            migrationBuilder.DropColumn(
                name: "turno",
                table: "per");

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
                newName: "vis");

            migrationBuilder.RenameTable(
                name: "minVig",
                newName: "minVis");

            migrationBuilder.RenameIndex(
                name: "IX_minVig_visitanteid",
                table: "minVis",
                newName: "IX_minVis_visitanteid");

            migrationBuilder.AlterColumn<string>(
                name: "numApartamento",
                table: "vis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "PK_vis",
                table: "vis",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_minVis",
                table: "minVis",
                column: "id");

            migrationBuilder.CreateTable(
                name: "adm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "minEve",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anotaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minEve", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "minVehVis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numParqueadero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehiculoid = table.Column<int>(type: "int", nullable: true),
                    visitanteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minVehVis", x => x.id);
                    table.ForeignKey(
                        name: "FK_minVehVis_veh_vehiculoid",
                        column: x => x.vehiculoid,
                        principalTable: "veh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVehVis_vis_visitanteid",
                        column: x => x.visitanteid,
                        principalTable: "vis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "res",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numApartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numParqueadero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_res", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vig",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false),
                    turno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vig", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "minCor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firmaRecibido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personaEntrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personaRecibe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    residenteid = table.Column<int>(type: "int", nullable: true),
                    tipoCorrespondencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minCor", x => x.id);
                    table.ForeignKey(
                        name: "FK_minCor_res_residenteid",
                        column: x => x.residenteid,
                        principalTable: "res",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "minVehRes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    residenteid = table.Column<int>(type: "int", nullable: true),
                    vehiculoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minVehRes", x => x.id);
                    table.ForeignKey(
                        name: "FK_minVehRes_res_residenteid",
                        column: x => x.residenteid,
                        principalTable: "res",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_minVehRes_veh_vehiculoid",
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
                name: "FK_minVis_vis_visitanteid",
                table: "minVis",
                column: "visitanteid",
                principalTable: "vis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
