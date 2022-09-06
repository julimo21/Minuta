using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_MinutaVehiculoResidentes_vehiculoid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_vehiculoid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_per_RolUsuario_Residente_tipoid",
                table: "per");

            migrationBuilder.DropForeignKey(
                name: "FK_per_RolUsuario_tipoid",
                table: "per");

            migrationBuilder.DropForeignKey(
                name: "FK_per_RolUsuario_Vigilante_tipoid",
                table: "per");

            migrationBuilder.DropIndex(
                name: "IX_per_Residente_tipoid",
                table: "per");

            migrationBuilder.DropIndex(
                name: "IX_per_Vigilante_tipoid",
                table: "per");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolUsuario",
                table: "RolUsuario");

            migrationBuilder.DropColumn(
                name: "Residente_tipoid",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Vigilante_tipoid",
                table: "per");

            migrationBuilder.RenameTable(
                name: "RolUsuario",
                newName: "tipUsu");

            migrationBuilder.RenameColumn(
                name: "numParqueadero",
                table: "per",
                newName: "numParqueaderoRes");

            migrationBuilder.RenameColumn(
                name: "numApartamento",
                table: "per",
                newName: "numApartamentoVis");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "per",
                newName: "numApartamentoRes");

            migrationBuilder.RenameColumn(
                name: "correo",
                table: "per",
                newName: "idUsuario");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "per",
                newName: "correoAdm");

            migrationBuilder.RenameColumn(
                name: "Visitante_numApartamento",
                table: "per",
                newName: "celularRes");

            migrationBuilder.RenameColumn(
                name: "Residente_celular",
                table: "per",
                newName: "celularAdm");

            migrationBuilder.RenameColumn(
                name: "vehiculoid",
                table: "minVig",
                newName: "vehiculoVisid");

            migrationBuilder.RenameColumn(
                name: "numParqueadero",
                table: "minVig",
                newName: "numParqueaderoVis");

            migrationBuilder.RenameColumn(
                name: "horaSalida",
                table: "minVig",
                newName: "horaSalidaVis");

            migrationBuilder.RenameColumn(
                name: "fechaSalida",
                table: "minVig",
                newName: "horaSalidaVehVis");

            migrationBuilder.RenameColumn(
                name: "MinutaVisitante_horaSalida",
                table: "minVig",
                newName: "fechaSalidaVis");

            migrationBuilder.RenameColumn(
                name: "MinutaVisitante_fechaSalida",
                table: "minVig",
                newName: "fechaSalidaVehVis");

            migrationBuilder.RenameColumn(
                name: "MinutaVehiculoResidentes_vehiculoid",
                table: "minVig",
                newName: "vehiculoResid");

            migrationBuilder.RenameIndex(
                name: "IX_minVig_vehiculoid",
                table: "minVig",
                newName: "IX_minVig_vehiculoVisid");

            migrationBuilder.RenameIndex(
                name: "IX_minVig_MinutaVehiculoResidentes_vehiculoid",
                table: "minVig",
                newName: "IX_minVig_vehiculoResid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipUsu",
                table: "tipUsu",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoResid",
                table: "minVig",
                column: "vehiculoResid",
                principalTable: "veh",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoVisid",
                table: "minVig",
                column: "vehiculoVisid",
                principalTable: "veh",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per",
                column: "tipoid",
                principalTable: "tipUsu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_vehiculoResid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_vehiculoVisid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipUsu",
                table: "tipUsu");

            migrationBuilder.RenameTable(
                name: "tipUsu",
                newName: "RolUsuario");

            migrationBuilder.RenameColumn(
                name: "numParqueaderoRes",
                table: "per",
                newName: "numParqueadero");

            migrationBuilder.RenameColumn(
                name: "numApartamentoVis",
                table: "per",
                newName: "numApartamento");

            migrationBuilder.RenameColumn(
                name: "numApartamentoRes",
                table: "per",
                newName: "id_usuario");

            migrationBuilder.RenameColumn(
                name: "idUsuario",
                table: "per",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "correoAdm",
                table: "per",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "celularRes",
                table: "per",
                newName: "Visitante_numApartamento");

            migrationBuilder.RenameColumn(
                name: "celularAdm",
                table: "per",
                newName: "Residente_celular");

            migrationBuilder.RenameColumn(
                name: "vehiculoVisid",
                table: "minVig",
                newName: "vehiculoid");

            migrationBuilder.RenameColumn(
                name: "vehiculoResid",
                table: "minVig",
                newName: "MinutaVehiculoResidentes_vehiculoid");

            migrationBuilder.RenameColumn(
                name: "numParqueaderoVis",
                table: "minVig",
                newName: "numParqueadero");

            migrationBuilder.RenameColumn(
                name: "horaSalidaVis",
                table: "minVig",
                newName: "horaSalida");

            migrationBuilder.RenameColumn(
                name: "horaSalidaVehVis",
                table: "minVig",
                newName: "fechaSalida");

            migrationBuilder.RenameColumn(
                name: "fechaSalidaVis",
                table: "minVig",
                newName: "MinutaVisitante_horaSalida");

            migrationBuilder.RenameColumn(
                name: "fechaSalidaVehVis",
                table: "minVig",
                newName: "MinutaVisitante_fechaSalida");

            migrationBuilder.RenameIndex(
                name: "IX_minVig_vehiculoVisid",
                table: "minVig",
                newName: "IX_minVig_vehiculoid");

            migrationBuilder.RenameIndex(
                name: "IX_minVig_vehiculoResid",
                table: "minVig",
                newName: "IX_minVig_MinutaVehiculoResidentes_vehiculoid");

            migrationBuilder.AddColumn<int>(
                name: "Residente_tipoid",
                table: "per",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vigilante_tipoid",
                table: "per",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolUsuario",
                table: "RolUsuario",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_per_Residente_tipoid",
                table: "per",
                column: "Residente_tipoid");

            migrationBuilder.CreateIndex(
                name: "IX_per_Vigilante_tipoid",
                table: "per",
                column: "Vigilante_tipoid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_per_RolUsuario_Residente_tipoid",
                table: "per",
                column: "Residente_tipoid",
                principalTable: "RolUsuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_per_RolUsuario_tipoid",
                table: "per",
                column: "tipoid",
                principalTable: "RolUsuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_per_RolUsuario_Vigilante_tipoid",
                table: "per",
                column: "Vigilante_tipoid",
                principalTable: "RolUsuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
