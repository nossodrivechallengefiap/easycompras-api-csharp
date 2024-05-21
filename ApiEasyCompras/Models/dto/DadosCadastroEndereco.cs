using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosCadastroEndereco
    {
        [Required]
        public string Numero { get; init; }

        [StringLength(100)]
        public string Complemento { get; init; }

        [Required]
        [RegularExpression(@"\d{5}-\d{3}")]
        public string Cep { get; init; }
    }
}
