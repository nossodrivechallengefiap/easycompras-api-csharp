using System;
using br.com.easycompras.api_easycompras.model.entity;

namespace Models.DTO
{
    public record DadosListagemSolicitacao
    {
        public long CodigoSolicitacao { get; init; }
        public string Sku { get; init; }
        public string NomeProduto { get; init; }
        public string Descricao { get; init; }
        public long Quantidade { get; init; }
        public string Nome { get; init; }
        public string Email { get; init; }
        public DateTime DataSolicitacao { get; init; }

        public DadosListagemSolicitacao(Solicitacao solicitacao)
        {
            CodigoSolicitacao = solicitacao.CodigoSolicitacao;
            Sku = solicitacao.Produto.Sku;
            NomeProduto = solicitacao.Produto.NomeProduto;
            Descricao = solicitacao.Produto.Descricao;
            Quantidade = solicitacao.Quantidade;
            Nome = solicitacao.Usuario.Nome;
            Email = solicitacao.Usuario.Email;
            DataSolicitacao = solicitacao.DataSolicitacao;
        }
    }
}
