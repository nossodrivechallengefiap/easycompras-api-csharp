using Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Models
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> GetAllProdutosAsync();
        Task<Produto> GetProdutoBySkuAsync(string sku);
        Task<Produto> AddProdutoAsync(Produto produto);
        Task<Produto> UpdateProdutoAsync(string sku, Produto produto);
        Task<Produto> DeleteProdutoAsync(string sku);
    }
}
