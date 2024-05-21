using System;
using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosCadastroCotacao
    {
        [Required]
        [Valid]
        public DadosCadastroSolicitacao Solicitacao { get; init; }

        [Required]
        [Valid]
        public DadosCadastroFornecedor Fornecedor { get; init; }

        [Required]
        public decimal ValorUnitario { get; init; }

        public DateTime DataEntregaPrevista { get; init; }

        [Required]
        public DateTime DataCotacao { get; init; }

        [Required]
        public bool CotacaoAprovada { get; init; }
    }
}
