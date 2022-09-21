using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minuta.App.Persistencia.Migrations
{
    public partial class Nueva9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per");

            migrationBuilder.DropTable(
                name: "tipUsu");

            migrationBuilder.DropIndex(
                name: "IX_per_tipoid",
                table: "per");

            migrationBuilder.DropColumn(
                name: "contrasena",
                table: "per");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "per");

            migrationBuilder.DropColumn(
                name: "tipoid",
                table: "per");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contrasena",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idUsuario",
                table: "per",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoid",
                table: "per",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tipUsu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipUsu", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_per_tipoid",
                table: "per",
                column: "tipoid");

            migrationBuilder.AddForeignKey(
                name: "FK_per_tipUsu_tipoid",
                table: "per",
                column: "tipoid",
                principalTable: "tipUsu",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
