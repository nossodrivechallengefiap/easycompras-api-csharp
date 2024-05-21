using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosAtualizacaoEnderecoSemPK
    {
        public string Numero { get; init; }

        [StringLength(100)]
        public string Complemento { get; init; }

        [RegularExpression(@"\d{5}-\d{3}")]
        public string Cep { get; init; }
    }
}
