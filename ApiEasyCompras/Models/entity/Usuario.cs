using Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Models.Entity
{
    [Table("EC_USUARIOS")]
    public class Usuario
    {
        [Key]
        [Column("CODIGO_USUARIO")]
        public long CodigoUsuario { get; set; }

        [Required]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [Column("SENHA")]
        public string Senha { get; set; }

        [Required]
        [Column("EMAIL")]
        [Index(IsUnique = true, Name = "UK_EC_USUARIOS_EMAIL")]
        public string Email { get; set; }

        [ForeignKey("Endereco")]
        [Column("CODIGO_ENDERECO")]
        public long? CodigoEndereco { get; set; }

        public Endereco Endereco { get; set; }

        // CONSTRUTORES
        public Usuario() { }

        public Usuario(DadosCadastroUsuarioComFK dados)
        {
            Nome = dados.Nome;
            Senha = dados.Senha;
            Email = dados.Email;
        }

        public Usuario(DadosCadastroUsuario dados)
        {
            Nome = dados.Nome;
            Senha = dados.Senha;
            Email = dados.Email;
            Endereco = new Endereco(dados.Endereco);
        }

        public void Atualizar(DadosAtualizacaoUsuario dados)
        {
            Nome = dados.Nome ?? Nome;
            Senha = dados.Senha ?? Senha;
            Email = dados.Email ?? Email;
            Endereco?.AtualizarSemPK(dados.Endereco);
        }

        public void AtualizarSemPK(DadosAtualizacaoUsuarioSemPK dados)
        {
            Nome = dados.Nome ?? Nome;
            Senha = dados.Senha ?? Senha;
            Email = dados.Email ?? Email;
            Endereco?.AtualizarSemPK(dados.Endereco);
        }

        // TO STRING
        public override string ToString()
        {
            return $"Usuario [CodigoUsuario={CodigoUsuario}, Nome={Nome}, Senha={Senha}, Email={Email}, Endereco={Endereco}]";
        }
    }
}
