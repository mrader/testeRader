using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuntoVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntoVenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImporteTotalAPagar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImporteRealPagado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: true),
                    puntoVentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaccion_Cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaccion_PuntoVenta_puntoVentaId",
                        column: x => x.puntoVentaId,
                        principalTable: "PuntoVenta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaccion_clienteId",
                table: "Transaccion",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaccion_puntoVentaId",
                table: "Transaccion",
                column: "puntoVentaId");

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Cliente 1" });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Cliente 2" });

            migrationBuilder.InsertData(
                table: "PuntoVenta",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { 1, "Punto Venta 1" });

            migrationBuilder.InsertData(
                table: "PuntoVenta",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { 2, "Punto Venta 2" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaccion");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "PuntoVenta");
        }
    }
}
