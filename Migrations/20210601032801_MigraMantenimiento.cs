using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MaxService.Migrations
{
    public partial class MigraMantenimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Llanta_T_DetalleLlanta_DetalleLlantaId",
                table: "T_Llanta");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Llanta_T_Vehiculo_VehiculoId",
                table: "T_Llanta");

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "T_Llanta",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DetalleLlantaId",
                table: "T_Llanta",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "t_login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_login", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_T_Llanta_T_DetalleLlanta_DetalleLlantaId",
                table: "T_Llanta",
                column: "DetalleLlantaId",
                principalTable: "T_DetalleLlanta",
                principalColumn: "DetalleLlantaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Llanta_T_Vehiculo_VehiculoId",
                table: "T_Llanta",
                column: "VehiculoId",
                principalTable: "T_Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Llanta_T_DetalleLlanta_DetalleLlantaId",
                table: "T_Llanta");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Llanta_T_Vehiculo_VehiculoId",
                table: "T_Llanta");

            migrationBuilder.DropTable(
                name: "t_login");

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "T_Llanta",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DetalleLlantaId",
                table: "T_Llanta",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Llanta_T_DetalleLlanta_DetalleLlantaId",
                table: "T_Llanta",
                column: "DetalleLlantaId",
                principalTable: "T_DetalleLlanta",
                principalColumn: "DetalleLlantaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Llanta_T_Vehiculo_VehiculoId",
                table: "T_Llanta",
                column: "VehiculoId",
                principalTable: "T_Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
