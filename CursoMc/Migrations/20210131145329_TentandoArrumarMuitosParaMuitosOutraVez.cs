using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoMc.Migrations
{
    public partial class TentandoArrumarMuitosParaMuitosOutraVez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaProduto_Categorias_FichasId",
                table: "CategoriaProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaProduto_Produtos_FichasId1",
                table: "CategoriaProduto");

            migrationBuilder.RenameColumn(
                name: "FichasId1",
                table: "CategoriaProduto",
                newName: "ProdutosId");

            migrationBuilder.RenameColumn(
                name: "FichasId",
                table: "CategoriaProduto",
                newName: "CategoriasId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaProduto_FichasId1",
                table: "CategoriaProduto",
                newName: "IX_CategoriaProduto_ProdutosId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaProduto_Categorias_CategoriasId",
                table: "CategoriaProduto",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaProduto_Produtos_ProdutosId",
                table: "CategoriaProduto",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaProduto_Categorias_CategoriasId",
                table: "CategoriaProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaProduto_Produtos_ProdutosId",
                table: "CategoriaProduto");

            migrationBuilder.RenameColumn(
                name: "ProdutosId",
                table: "CategoriaProduto",
                newName: "FichasId1");

            migrationBuilder.RenameColumn(
                name: "CategoriasId",
                table: "CategoriaProduto",
                newName: "FichasId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaProduto_ProdutosId",
                table: "CategoriaProduto",
                newName: "IX_CategoriaProduto_FichasId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaProduto_Categorias_FichasId",
                table: "CategoriaProduto",
                column: "FichasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaProduto_Produtos_FichasId1",
                table: "CategoriaProduto",
                column: "FichasId1",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
