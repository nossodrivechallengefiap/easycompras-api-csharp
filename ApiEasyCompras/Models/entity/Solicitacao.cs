using Models.DTO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    [Table("EC_SOLICITACOES")]
    public class Solicitacao
    {
        [Key]
        [Column("CODIGO_SOLICITACAO")]
        public long CodigoSolicitacao { get; set; }

        [Required]
        [ForeignKey("Produto")]
        [Column("SKU")]
        public string Sku { get; set; }

        public Produto Produto { get; set; }

        [Required]
        [Column("QUANTIDADE")]
        public long Quantidade { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        [Column("CODIGO_USUARIO")]
        public long CodigoUsuario { get; set; }

        public Usuario Usuario { get; set; }

        [Required]
        [Column("DATA_SOLICITACAO")]
        public DateTime DataSolicitacao { get; set; }

        // CONSTRUTORES
        public Solicitacao() { }

        public Solicitacao(DadosCadastroSolicitacao dados)
        {
            Produto = new Produto(dados.Produto);
            Quantidade = dados.Quantidade;
            Usuario = new Usuario(dados.Usuario);
            DataSolicitacao = dados.DataSolicitacao;
        }

        public void Atualizar(DadosAtualizacaoSolicitacao dados)
        {
            Produto?.Atualizar(dados.Produto);
            Quantidade = dados.Quantidade ?? Quantidade;
            Usuario?.AtualizarSemPK(dados.Usuario);
            DataSolicitacao = dados.DataSolicitacao ?? DataSolicitacao;
        }

        public void AtualizarSemPK(DadosAtualizacaoSolicitacaoSemPK dados)
        {
            Produto?.Atualizar(dados.Produto);
            Quantidade = dados.Quantidade ?? Quantidade;
            Usuario?.AtualizarSemPK(dados.Usuario);
            DataSolicitacao = dados.DataSolicitacao ?? DataSolicitacao;
        }

        // TO STRING
        public override string ToString()
        {
            return $"Solicitacao [CodigoSolicitacao={CodigoSolicitacao}, Sku={Sku}, Quantidade={Quantidade}, CodigoUsuario={CodigoUsuario}, DataSolicitacao={DataSolicitacao}]";
        }
    }
}
