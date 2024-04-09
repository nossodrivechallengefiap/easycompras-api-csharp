using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
    }
}
