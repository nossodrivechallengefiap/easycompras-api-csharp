using Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    [Table("EC_PRODUTOS")]
    public class Produto
    {
        [Key]
        [Column("SKU")]
        public string Sku { get; set; }

        [Required]
        [Column("NOME_PRODUTO")]
        public string NomeProduto { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        // CONSTRUTORES
        public Produto() { }

        public Produto(DadosCadastroProduto dados)
        {
            Sku = dados.Sku;
            NomeProduto = dados.NomeProduto;
            Descricao = dados.Descricao;
        }

        public void Atualizar(DadosAtualizacaoProduto dados)
        {
            NomeProduto = dados.NomeProduto ?? NomeProduto;
            Descricao = dados.Descricao ?? Descricao;
        }

        // TO STRING
        public override string ToString()
        {
            return $"Produto [Sku={Sku}, NomeProduto={NomeProduto}, Descricao={Descricao}]";
        }
    }
}
