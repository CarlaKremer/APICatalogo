using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Categorias")] //Data annotation, indica nome da tabela no banco de dados
public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    [Key] //Data annotation, indica chave primária
    public int CategoriaId { get; set; } // colocando Id no final do nome ( ou o nome ser apenas Id) o Entity Framework vai enteder que é a chave primária
    [Required] //Data annotation, indica que o campo é obrigatório
    [StringLength(80)] //Data annotation, indica tamanho máximo do campo
    public string? Nome { get; set; }
    [Required] //Data annotation, indica que o campo é obrigatório
    [StringLength(300)] //Data annotation, indica tamanho máximo do campo
    public string? ImagemUrl { get; set; }


    public ICollection<Produto>? Produtos { get; set; } //propriedade de navegação

}
