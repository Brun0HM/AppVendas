using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo não pode ser vazio!")]
        [MaxLength(100, ErrorMessage = "O campo deve ter no máximo, 100 caracteres")]
        [MinLength(3, ErrorMessage = "O campo deve ter no mínimo, 3 caracteres")]
        public string ProdutoNome { get; set; }
        [Required(ErrorMessage = "O Campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo")]
        public double Valor { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser positivo")]
        [Required(ErrorMessage = "O Campo não pode ser vazio!")]
        [Display(Name = "Estoque atual")]
        public double QtadeEstoque { get; set; }
        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; }
        /* Chave Estrangeira */
        [Required(ErrorMessage = "Por favor selecione um Categoria!")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}