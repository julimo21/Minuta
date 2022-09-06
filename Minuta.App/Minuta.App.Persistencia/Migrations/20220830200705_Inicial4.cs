using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVehRes_Vehiculo_vehiculoid",
                table: "minVehRes");

            migrationBuilder.DropForeignKey(
                name: "FK_minVehVis_Vehiculo_vehiculoid",
                table: "minVehVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo");

            migrationBuilder.RenameTable(
                name: "Vehiculo",
                newName: "veh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_veh",
                table: "veh",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVehRes_veh_vehiculoid",
                table: "minVehRes",
                column: "vehiculoid",
                principalTable: "veh",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVehVis_veh_vehiculoid",
                table: "minVehVis",
                column: "vehiculoid",
                principalTable: "veh",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minVehRes_veh_vehiculoid",
                table: "minVehRes");

            migrationBuilder.DropForeignKey(
                name: "FK_minVehVis_veh_vehiculoid",
                table: "minVehVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_veh",
                table: "veh");

            migrationBuilder.RenameTable(
                name: "veh",
                newName: "Vehiculo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVehRes_Vehiculo_vehiculoid",
                table: "minVehRes",
                column: "vehiculoid",
                principalTable: "Vehiculo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVehVis_Vehiculo_vehiculoid",
                table: "minVehVis",
                column: "vehiculoid",
                principalTable: "Vehiculo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
