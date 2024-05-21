using Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Models
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllUsuariosAsync();
        Task<Usuario> GetUsuarioByIdAsync(long codigoUsuario);
        Task<Usuario> AddUsuarioAsync(Usuario usuario);
        Task<Usuario> UpdateUsuarioAsync(long codigoUsuario, Usuario usuario);
        Task<Usuario> DeleteUsuarioAsync(long codigoUsuario);
    }
}
