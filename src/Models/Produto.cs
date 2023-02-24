using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMVCBasica.Models;

public class Produto : Entity
{
    public Guid FornecedorId { get; set; }

    [Required(ErrorMessage = "O campo {0} não pode ser vazio.")]
    [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O campo {0} não pode ser vazio.")]
    [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "O campo {0} não pode ser vazio.")]
    [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
    public string? Imagem { get; set; }

    [Required(ErrorMessage = "O campo {0} não pode ser vazio.")]
    public decimal Valor { get; set; }

    [DisplayName("Ativo?")]
    public bool Ativo { get; set; }

    /* EF Relations */
    public Fornecedor? Fornecedor { get; set; }
}
