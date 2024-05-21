using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosCadastroUsuarioComFK
    {
        [Required]
        [StringLength(255)]
        public string Nome { get; init; }

        [Required]
        [StringLength(255)]
        public string Senha { get; init; }

        [Required]
        [StringLength(255)]
        public string Email { get; init; }

        [Required]
        public long CodigoEndereco { get; init; }
    }
}
