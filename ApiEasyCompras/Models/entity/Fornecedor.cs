using Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Models.Entity
{
    [Table("EC_FORNECEDORES", UniqueConstraints = new[] { new UniqueConstraint("UK_EC_FORNECEDORES_EMAIL", nameof(Email)) })]
    public class Fornecedor
    {
        [Key]
        [Column("CODIGO_FORNECEDOR")]
        public long CodigoFornecedor { get; set; }

        [Required]
        [Column("RAZAO_SOCIAL")]
        public string RazaoSocial { get; set; }

        [Required]
        [Column("CNPJ")]
        public string Cnpj { get; set; }

        [Column("NOME_CONTATO")]
        public string NomeContato { get; set; }

        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Required]
        [Column("EMAIL")]
        public string Email { get; set; }

        [ForeignKey("FK_FORNECEDOR_ENDERECOS")]
        [Required]
        [Column("CODIGO_ENDERECO")]
        public long CodigoEndereco { get; set; }
        public Endereco Endereco { get; set; }

        // CONSTRUTOR
        public Fornecedor() { }

        public Fornecedor(DadosCadastroFornecedor dados)
        {
            RazaoSocial = dados.RazaoSocial;
            Cnpj = dados.Cnpj;
            NomeContato = dados.NomeContato;
            Telefone = dados.Telefone;
            Email = dados.Email;
            Endereco = new Endereco(dados.Endereco);
        }

        public void Atualizar(DadosAtualizacaoFornecedor dados)
        {
            RazaoSocial = dados.RazaoSocial ?? RazaoSocial;
            Cnpj = dados.Cnpj ?? Cnpj;
            NomeContato = dados.NomeContato ?? NomeContato;
            Telefone = dados.Telefone ?? Telefone;
            Email = dados.Email ?? Email;
            Endereco.AtualizarSemPK(dados.Endereco);
        }

        public void AtualizarSemPK(DadosAtualizacaoFornecedorSemPK dados)
        {
            RazaoSocial = dados.RazaoSocial ?? RazaoSocial;
            Cnpj = dados.Cnpj ?? Cnpj;
            NomeContato = dados.NomeContato ?? NomeContato;
            Telefone = dados.Telefone ?? Telefone;
            Email = dados.Email ?? Email;
            Endereco.AtualizarSemPK(dados.Endereco);
        }

        // TO STRING
        public override string ToString()
        {
            return $"Fornecedor [CodigoFornecedor={CodigoFornecedor}, RazaoSocial={RazaoSocial}, Cnpj={Cnpj}, NomeContato={NomeContato}, Telefone={Telefone}, Email={Email}, Endereco={Endereco}]";
        }
    }
}
