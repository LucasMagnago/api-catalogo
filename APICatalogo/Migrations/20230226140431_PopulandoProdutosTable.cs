using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoProdutosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "VALUES('Coca-Cola', 'Refrigerante de Cola 350ml', 5.45, 'cocacola.jpg', 50, GETDATE(), 7)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao,  Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "VALUES('Salgado', 'Salgado', 7.45, 'salgado.jpg', 20, GETDATE(), 8)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao,  Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "VALUES('Sorvete', 'Sorvete', 5.50, 'sorvete.jpg', 15, GETDATE(), 9)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos"); //Utilizado para deletar os dados da tabela criados fora desta migração
        }
    }
}
