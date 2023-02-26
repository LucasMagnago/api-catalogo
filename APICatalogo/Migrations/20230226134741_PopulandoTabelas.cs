using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES('Sobremesas', 'sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias"); //Utilizado para deletar os dados da tabela criados fora desta migração
        }
    }
}
