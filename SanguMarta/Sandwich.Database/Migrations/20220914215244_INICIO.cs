using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sandwich.Database.Migrations
{
    public partial class INICIO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tiposdeSanguchasos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPedido = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Fecha = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    Horario = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposdeSanguchasos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanguchasos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoXDocena = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    TipoSanguche = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    codigo = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    PedidoVentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanguchasos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sanguchasos_tiposdeSanguchasos_PedidoVentaId",
                        column: x => x.PedidoVentaId,
                        principalTable: "tiposdeSanguchasos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "codigo",
                table: "sanguchasos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sanguchasos_PedidoVentaId",
                table: "sanguchasos",
                column: "PedidoVentaId");

            migrationBuilder.CreateIndex(
                name: "CodigoPedido",
                table: "tiposdeSanguchasos",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sanguchasos");

            migrationBuilder.DropTable(
                name: "tiposdeSanguchasos");
        }
    }
}
