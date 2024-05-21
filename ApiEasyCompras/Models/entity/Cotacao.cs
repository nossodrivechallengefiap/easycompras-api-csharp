using Models.DTO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    [Table("EC_COTACOES")]
    public class Cotacao
    {
        [Key]
        [Column("CODIGO_COTACAO")]
        public long CodigoCotacao { get; set; }

        [ForeignKey("CODIGO_SOLICITACAO")]
        public Solicitacao Solicitacao { get; set; }

        [ForeignKey("CODIGO_FORNECEDOR")]
        public Fornecedor Fornecedor { get; set; }

        [Column("VALOR_UNITARIO", TypeName = "decimal(18, 2)")]
        public decimal ValorUnitario { get; set; }

        [Column("DATA_ENTREGA_PREVISTA")]
        public DateTime? DataEntregaPrevista { get; set; }

        [Column("DATA_COTACAO")]
        public DateTime DataCotacao { get; set; }

        [Column("COTACAO_APROVADA")]
        public bool CotacaoAprovada { get; set; }

        // CONSTRUTOR
        public Cotacao() { }

        public Cotacao(DadosCadastroCotacao dados)
        {
            Solicitacao = new Solicitacao(dados.Solicitacao);
            Fornecedor = new Fornecedor(dados.Fornecedor);
            ValorUnitario = dados.ValorUnitario;
            DataEntregaPrevista = dados.DataEntregaPrevista;
            DataCotacao = dados.DataCotacao;
            CotacaoAprovada = dados.CotacaoAprovada;
        }

        public void Atualizar(DadosAtualizacaoCotacao dados)
        {
            if (dados.Solicitacao != null)
                Solicitacao.AtualizarSemPK(dados.Solicitacao);

            if (dados.Fornecedor != null)
                Fornecedor.AtualizarSemPK(dados.Fornecedor);

            if (dados.ValorUnitario != null)
                ValorUnitario = dados.ValorUnitario.Value;

            if (dados.DataEntregaPrevista != null)
                DataEntregaPrevista = dados.DataEntregaPrevista;

            if (dados.DataCotacao != null)
                DataCotacao = dados.DataCotacao.Value;

            if (dados.CotacaoAprovada != null)
                CotacaoAprovada = dados.CotacaoAprovada.Value;
        }

        // TO STRING
        public override string ToString()
        {
            return "Cotacao [" +
                   "CodigoCotacao=" + CodigoCotacao +
                   ", Solicitacao=" + Solicitacao +
                   ", Fornecedor=" + Fornecedor +
                   ", ValorUnitario=" + ValorUnitario +
                   ", DataEntregaPrevista=" + DataEntregaPrevista +
                   ", DataCotacao=" + DataCotacao +
                   ", CotacaoAprovada=" + CotacaoAprovada +
                   "]";
        }
    }
}
