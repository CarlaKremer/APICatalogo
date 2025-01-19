using System.Collections.ObjectModel;

namespace APICatalogo.Models;

public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    public int CategoriaId { get; set; } // colocando Id no final do nome ( ou o nome ser apenas Id) o Entity Framework vai enteder que é a chave primária
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }


    public ICollection<Produto>? Produtos { get; set; } //propriedade de navegação

}
