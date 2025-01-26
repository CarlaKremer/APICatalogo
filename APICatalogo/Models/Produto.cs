using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

[Table("Produtos")] //Data annotation, indica nome da tabela no banco de dados
public class Produto
{
    [Key] //Data annotation, indica chave primária
    public int ProdutoId { get; set; }
    [Required] //Data annotation, indica que o campo é obrigatório
    [StringLength(80)] //Data annotation, indica tamanho máximo do campo
    public string? Nome { get; set; }
    [Required]
    [StringLength(300)] 
    public string? Descricao { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")] //Data annotation, indica tipo de dado e tamanho
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; } //caminho da imagem
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }


    public int CategoriaId { get; set; } //chave estrangeira
    [JsonIgnore]
    public Categoria? Categoria { get; set; } //propriedade de navegação
}
