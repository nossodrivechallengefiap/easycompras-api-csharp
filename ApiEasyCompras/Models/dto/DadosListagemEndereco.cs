namespace Models.DTO
{
    public record DadosListagemEndereco
    {
        public long CodigoEndereco { get; init; }
        public string Numero { get; init; }
        public string Complemento { get; init; }
        public string Cep { get; init; }

        public DadosListagemEndereco(Endereco endereco)
        {
            CodigoEndereco = endereco.CodigoEndereco;
            Numero = endereco.Numero;
            Complemento = endereco.Complemento;
            Cep = endereco.Cep;
        }
    }
}
