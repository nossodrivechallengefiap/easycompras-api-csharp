using System;
using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosAtualizacaoSolicitacaoSemPK
    {
        [Required]
        public DadosAtualizacaoProduto Produto { get; init; }

        public long? Quantidade { get; init; }

        [Required]
        public DadosAtualizacaoUsuarioSemPK Usuario { get; init; }

        public DateTime DataSolicitacao { get; init; }
    }
}
