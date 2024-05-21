using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosAtualizacaoProduto
    {
        [Required]
        public string Sku { get; init; }

        [StringLength(255)]
        public string NomeProduto { get; init; }

        [StringLength(1000)]
        public string Descricao { get; init; }
    }
}