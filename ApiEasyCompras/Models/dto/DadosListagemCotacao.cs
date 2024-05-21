using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using br.com.easycompras.api_easycompras.model.entity;

namespace Models.DTO
{
    public record DadosListagemCotacao
    {
        public long CodigoCotacao { get; init; }
        public string Sku { get; init; }
        public string NomeProduto { get; init; }
        public string Descricao { get; init; }
        public long Quantidade { get; init; }
        public string Nome { get; init; }
        public string EmailUsuario { get; init; }
        public string RazaoSocial { get; init; }
        public string Cnpj { get; init; }
        public string NomeContato { get; init; }
        public string EmailFornecedor { get; init; }
        public decimal ValorUnitario { get; init; }
        public DateTime DataEntregaPrevista { get; init; }
        public DateTime DataCotacao { get; init; }
        public bool CotacaoAprovada { get; init; }

        public DadosListagemCotacao(Cotacao cotacao)
        {
            CodigoCotacao = cotacao.CodigoCotacao;
            Sku = cotacao.Solicitacao.Produto.Sku;
            NomeProduto = cotacao.Solicitacao.Produto.NomeProduto;
            Descricao = cotacao.Solicitacao.Produto.Descricao;
            Quantidade = cotacao.Solicitacao.Quantidade;
            Nome = cotacao.Solicitacao.Usuario.Nome;
            EmailUsuario = cotacao.Solicitacao.Usuario.Email;
            RazaoSocial = cotacao.Fornecedor.RazaoSocial;
            Cnpj = cotacao.Fornecedor.Cnpj;
            NomeContato = cotacao.Fornecedor.NomeContato;
            EmailFornecedor = cotacao.Fornecedor.Email;
            ValorUnitario = cotacao.ValorUnitario;
            DataEntregaPrevista = cotacao.DataEntregaPrevista;
            DataCotacao = cotacao.DataCotacao;
            CotacaoAprovada = cotacao.CotacaoAprovada;
        }
    }
}
