namespace Models.DTO
{
    public record DadosListagemFornecedor
    {
        public long CodigoFornecedor { get; init; }
        public string RazaoSocial { get; init; }
        public string Cnpj { get; init; }
        public string NomeContato { get; init; }
        public string Telefone { get; init; }
        public string Email { get; init; }
        public string Numero { get; init; }
        public string Complemento { get; init; }
        public string Cep { get; init; }

        public DadosListagemFornecedor(Fornecedor fornecedor)
        {
            CodigoFornecedor = fornecedor.CodigoFornecedor;
            RazaoSocial = fornecedor.RazaoSocial;
            Cnpj = fornecedor.Cnpj;
            NomeContato = fornecedor.NomeContato;
            Telefone = fornecedor.Telefone;
            Email = fornecedor.Email;
            Numero = fornecedor.Endereco.Numero;
            Complemento = fornecedor.Endereco.Complemento;
            Cep = fornecedor.Endereco.Cep;
        }
    }
}
