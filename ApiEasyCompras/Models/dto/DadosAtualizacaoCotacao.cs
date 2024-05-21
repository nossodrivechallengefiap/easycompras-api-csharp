using System;
using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public class DadosAtualizacaoCotacao
    {
        [Required]
        public long CodigoCotacao { get; set; }

        [Required]
        public DadosAtualizacaoSolicitacaoSemPK Solicitacao { get; set; }

        [Required]
        public DadosAtualizacaoFornecedorSemPK Fornecedor { get; set; }

        public decimal ValorUnitario { get; set; }

        public DateTime DataEntregaPrevista { get; set; }

        public DateTime DataCotacao { get; set; }

        public bool CotacaoAprovada { get; set; }
    }
}
