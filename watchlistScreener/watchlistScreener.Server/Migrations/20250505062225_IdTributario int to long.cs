using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace watchlistScreener.Server.Migrations
{
    /// <inheritdoc />
    public partial class IdTributariointtolong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "IdentificacionTributaria",
                table: "Proveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdentificacionTributaria",
                table: "Proveedores",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
