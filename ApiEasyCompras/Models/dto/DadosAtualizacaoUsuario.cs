using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosAtualizacaoUsuario
    {
        [Required]
        public long CodigoUsuario { get; init; }

        [StringLength(255)]
        public string Nome { get; init; }

        [StringLength(255)]
        public string Senha { get; init; }

        [StringLength(255)]
        public string Email { get; init; }

        [Required]
        public DadosAtualizacaoEnderecoSemPK Endereco { get; init; }
    }
}
