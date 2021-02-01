using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoMc.Migrations
{
    public partial class PedidoPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoPagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPagamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoComBoletos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoPagamentoId = table.Column<int>(type: "int", nullable: false),
                    PedidoId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoComBoletos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_PagamentoComBoletos_EstadoPagamentos_EstadoPagamentoId",
                        column: x => x.EstadoPagamentoId,
                        principalTable: "EstadoPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagamentoComBoletos_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoComCartaos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeParcelas = table.Column<int>(type: "int", nullable: false),
                    EstadoPagamentoId = table.Column<int>(type: "int", nullable: false),
                    PedidoId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoComCartaos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_PagamentoComCartaos_EstadoPagamentos_EstadoPagamentoId",
                        column: x => x.EstadoPagamentoId,
                        principalTable: "EstadoPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagamentoComCartaos_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoComBoletos_EstadoPagamentoId",
                table: "PagamentoComBoletos",
                column: "EstadoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoComBoletos_PedidoId1",
                table: "PagamentoComBoletos",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoComCartaos_EstadoPagamentoId",
                table: "PagamentoComCartaos",
                column: "EstadoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoComCartaos_PedidoId1",
                table: "PagamentoComCartaos",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PagamentoComBoletos");

            migrationBuilder.DropTable(
                name: "PagamentoComCartaos");

            migrationBuilder.DropTable(
                name: "EstadoPagamentos");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
