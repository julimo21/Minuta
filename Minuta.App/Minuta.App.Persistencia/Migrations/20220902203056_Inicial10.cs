using Microsoft.EntityFrameworkCore.Migrations;

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Inicial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Residente_contrasena",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Residente_usuario",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Vigilante_contrasena",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Vigilante_usuario",
                table: "per");

            migrationBuilder.DropColumn(
                name: "tipoUsuario",
                table: "per");

            migrationBuilder.RenameColumn(
                name: "usuario",
                table: "per",
                newName: "id_usuario");

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

            migrationBuilder.AddColumn<int>(
                name: "tipoid",
                table: "per",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RolUsuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuario", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_per_Residente_tipoid",
                table: "per",
                column: "Residente_tipoid");

            migrationBuilder.CreateIndex(
                name: "IX_per_tipoid",
                table: "per",
                column: "tipoid");

            migrationBuilder.CreateIndex(
                name: "IX_per_Vigilante_tipoid",
                table: "per",
                column: "Vigilante_tipoid");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_per_RolUsuario_Residente_tipoid",
                table: "per");

            migrationBuilder.DropForeignKey(
                name: "FK_per_RolUsuario_tipoid",
                table: "per");

            migrationBuilder.DropForeignKey(
                name: "FK_per_RolUsuario_Vigilante_tipoid",
                table: "per");

            migrationBuilder.DropTable(
                name: "RolUsuario");

            migrationBuilder.DropIndex(
                name: "IX_per_Residente_tipoid",
                table: "per");

            migrationBuilder.DropIndex(
                name: "IX_per_tipoid",
                table: "per");

            migrationBuilder.DropIndex(
                name: "IX_per_Vigilante_tipoid",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Residente_tipoid",
                table: "per");

            migrationBuilder.DropColumn(
                name: "Vigilante_tipoid",
                table: "per");

            migrationBuilder.DropColumn(
                name: "tipoid",
                table: "per");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "per",
                newName: "usuario");

            migrationBuilder.AddColumn<string>(
                name: "Residente_contrasena",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residente_usuario",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vigilante_contrasena",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vigilante_usuario",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoUsuario",
                table: "per",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
