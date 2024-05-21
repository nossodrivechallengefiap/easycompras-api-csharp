using System;
using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public record DadosCadastroSolicitacao
    {
        [Required]
        [Valid]
        public DadosCadastroProduto Produto { get; init; }

        [Required]
        public long Quantidade { get; init; }

        [Required]
        [Valid]
        public DadosCadastroUsuario Usuario { get; init; }

        [Required]
        public DateTime DataSolicitacao { get; init; }
    }
}
