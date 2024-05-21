using Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    [Table("EC_ENDERECOS")]
    public class Endereco
    {
        [Key]
        [Column("CODIGO_ENDERECO")]
        public long CodigoEndereco { get; set; }

        [Required]
        [Column("NUMERO")]
        public string Numero { get; set; }

        [Column("COMPLEMENTO")]
        public string Complemento { get; set; }

        [Required]
        [Column("CEP")]
        public string Cep { get; set; }

        // CONSTRUTOR
        public Endereco() { }

        public Endereco(DadosCadastroEndereco dados)
        {
            Numero = dados.Numero;
            Complemento = dados.Complemento;
            Cep = dados.Cep;
        }

        public void Atualizar(DadosAtualizacaoEndereco dados)
        {
            if (dados.Numero != null)
                Numero = dados.Numero;

            if (dados.Complemento != null)
                Complemento = dados.Complemento;

            if (dados.Cep != null)
                Cep = dados.Cep;
        }

        public void AtualizarSemPK(DadosAtualizacaoEnderecoSemPK dados)
        {
            if (dados.Numero != null)
                Numero = dados.Numero;

            if (dados.Complemento != null)
                Complemento = dados.Complemento;

            if (dados.Cep != null)
                Cep = dados.Cep;
        }

        // TO STRING
        public override string ToString()
        {
            return $"Endereco [CodigoEndereco={CodigoEndereco}, Numero={Numero}, Complemento={Complemento}, Cep={Cep}]";
        }
    }
}
