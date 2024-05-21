using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosCadastroFornecedor
    {
        [Required]
        [StringLength(255)]
        public string RazaoSocial { get; init; }

        [Required]
        [RegularExpression(@"\d{2}.\d{3}.\d{3}/\d{4}-\d{2}")]
        public string Cnpj { get; init; }

        [StringLength(255)]
        public string NomeContato { get; init; }

        [StringLength(20)]
        public string Telefone { get; init; }

        [Required]
        [StringLength(255)]
        public string Email { get; init; }

        [Required]
        [Valid]
        public DadosCadastroEndereco Endereco { get; init; }
    }
}
