namespace Models.DTO
{
    public record DadosListagemProduto
    {
        public string Sku { get; init; }
        public string NomeProduto { get; init; }
        public string Descricao { get; init; }

        public DadosListagemProduto(Produto produto)
        {
            Sku = produto.Sku;
            NomeProduto = produto.NomeProduto;
            Descricao = produto.Descricao;
        }
    }
}
