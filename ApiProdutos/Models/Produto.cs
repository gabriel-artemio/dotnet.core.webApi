using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProdutos.Models;
public class Produto
{
    public int Id { get; set; }

    [MaxLength(80)]
    public string Nome { get; set; }
    
    [MaxLength(200)]
    public string Descricao { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
}

