using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoSoftWare_2022.Migrations
{
    public partial class datos5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alquileres_estadoDeAlquileres_estadosEstadoId",
                table: "alquileres");

            migrationBuilder.AlterColumn<int>(
                name: "estadosEstadoId",
                table: "alquileres",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_alquileres_estadoDeAlquileres_estadosEstadoId",
                table: "alquileres",
                column: "estadosEstadoId",
                principalTable: "estadoDeAlquileres",
                principalColumn: "EstadoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alquileres_estadoDeAlquileres_estadosEstadoId",
                table: "alquileres");

            migrationBuilder.AlterColumn<int>(
                name: "estadosEstadoId",
                table: "alquileres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_alquileres_estadoDeAlquileres_estadosEstadoId",
                table: "alquileres",
                column: "estadosEstadoId",
                principalTable: "estadoDeAlquileres",
                principalColumn: "EstadoId");
        }
    }
}
