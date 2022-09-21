using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Nueva6 : Migration
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
                name: "FK_minVig_veh_vehiculoResid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_vehiculoVisid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_MinutaCorrespondencia_residenteid",
                table: "minVig",
                column: "MinutaCorrespondencia_residenteid",
                principalTable: "per",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade
                );

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_MinutaVisitante_visitanteid",
                table: "minVig",
                column: "MinutaVisitante_visitanteid",
                principalTable: "per",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade
                );

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_residenteid",
                table: "minVig",
                column: "residenteid",
                principalTable: "per",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade
                );

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_visitanteid",
                table: "minVig",
                column: "visitanteid",
                principalTable: "per",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade
                );

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoResid",
                table: "minVig",
                column: "vehiculoResid",
                principalTable: "veh",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade
                );

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoVisid",
                table: "minVig",
                column: "vehiculoVisid",
                principalTable: "veh",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade
                );

            migrationBuilder.AddForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per",
                column: "tipoid",
                principalTable: "tipUsu",
                principalColumn: "id"
                //onDelete: ReferentialAction.Cascade}
                );
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
                name: "FK_minVig_veh_vehiculoResid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_minVig_veh_vehiculoVisid",
                table: "minVig");

            migrationBuilder.DropForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_MinutaCorrespondencia_residenteid",
                table: "minVig",
                column: "MinutaCorrespondencia_residenteid",
                principalTable: "per",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_MinutaVisitante_visitanteid",
                table: "minVig",
                column: "MinutaVisitante_visitanteid",
                principalTable: "per",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_residenteid",
                table: "minVig",
                column: "residenteid",
                principalTable: "per",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_per_visitanteid",
                table: "minVig",
                column: "visitanteid",
                principalTable: "per",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoResid",
                table: "minVig",
                column: "vehiculoResid",
                principalTable: "veh",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minVig_veh_vehiculoVisid",
                table: "minVig",
                column: "vehiculoVisid",
                principalTable: "veh",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per",
                column: "tipoid",
                principalTable: "tipUsu",
                principalColumn: "id");
        }
    }
}
