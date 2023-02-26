using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Categorias")] //Não é necessário, pois isso já foi definido no applicationDbContext
public class Categoria
{
    [Key] //Não é necessário, pois o EF define a propriedade com nome Id como PK
    public int Id { get; set; }

    [Required]
    [MaxLength(80)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(300)]
    public string ImagemUrl { get; set; }

    [Required]
    [MaxLength(300)]
    public ICollection<Produto> Produtos { get; set; }

    public Categoria()
    {
        this.Produtos = new Collection<Produto>();
    }
}

