namespace APICatalogo.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public string? ImagemUrl { get; set; } //caminho da imagem
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }


    public int CategoriaId { get; set; } //chave estrangeira
    public Categoria? Categoria { get; set; } //propriedade de navegação
}
