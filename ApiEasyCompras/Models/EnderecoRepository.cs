using Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Models
{
    public interface IEnderecoRepository
    {
        Task<List<Endereco>> GetAllEnderecosAsync();
        Task<Endereco> GetEnderecoByIdAsync(long id);
        Task<Endereco> AddEnderecoAsync(Endereco endereco);
        Task<Endereco> UpdateEnderecoAsync(long id, Endereco endereco);
        Task<Endereco> DeleteEnderecoAsync(long id);
    }
}
