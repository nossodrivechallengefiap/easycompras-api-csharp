namespace Models.DTO
{
    public record DadosListagemUsuario
    {
        public long CodigoUsuario { get; init; }
        public string Nome { get; init; }
        public string Senha { get; init; }
        public string Email { get; init; }
        public string Numero { get; init; }
        public string Complemento { get; init; }
        public string Cep { get; init; }

        public DadosListagemUsuario(Usuario usuario)
        {
            CodigoUsuario = usuario.CodigoUsuario;
            Nome = usuario.Nome;
            Senha = usuario.Senha;
            Email = usuario.Email;
            Numero = usuario.Endereco.Numero;
            Complemento = usuario.Endereco.Complemento;
            Cep = usuario.Endereco.Cep;
        }
    }
}
