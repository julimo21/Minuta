using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minCor_Persona_residenteid",
                table: "minCor");

            migrationBuilder.DropForeignKey(
                name: "FK_minVehRes_Persona_residenteid",
                table: "minVehRes");

            migrationBuilder.DropForeignKey(
                name: "FK_minVehVis_Persona_visitanteid",
                table: "minVehVis");

            migrationBuilder.DropForeignKey(
                name: "FK_minVis_Persona_visitanteid",
                table: "minVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "per");

            migrationBuilder.AddPrimaryKey(
                name: "PK_per",
                table: "per",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minCor_per_residenteid",
                table: "minCor",
                column: "residenteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVehRes_per_residenteid",
                table: "minVehRes",
                column: "residenteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVehVis_per_visitanteid",
                table: "minVehVis",
                column: "visitanteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVis_per_visitanteid",
                table: "minVis",
                column: "visitanteid",
                principalTable: "per",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_minCor_per_residenteid",
                table: "minCor");

            migrationBuilder.DropForeignKey(
                name: "FK_minVehRes_per_residenteid",
                table: "minVehRes");

            migrationBuilder.DropForeignKey(
                name: "FK_minVehVis_per_visitanteid",
                table: "minVehVis");

            migrationBuilder.DropForeignKey(
                name: "FK_minVis_per_visitanteid",
                table: "minVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_per",
                table: "per");

            migrationBuilder.RenameTable(
                name: "per",
                newName: "Persona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_minCor_Persona_residenteid",
                table: "minCor",
                column: "residenteid",
                principalTable: "Persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVehRes_Persona_residenteid",
                table: "minVehRes",
                column: "residenteid",
                principalTable: "Persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVehVis_Persona_visitanteid",
                table: "minVehVis",
                column: "visitanteid",
                principalTable: "Persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_minVis_Persona_visitanteid",
                table: "minVis",
                column: "visitanteid",
                principalTable: "Persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
