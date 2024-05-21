using Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Models
{
    public interface ISolicitacaoRepository
    {
        Task<List<Solicitacao>> GetAllSolicitacoesAsync();
        Task<Solicitacao> GetSolicitacaoByIdAsync(long codigoSolicitacao);
        Task<Solicitacao> AddSolicitacaoAsync(Solicitacao solicitacao);
        Task<Solicitacao> UpdateSolicitacaoAsync(long codigoSolicitacao, Solicitacao solicitacao);
        Task<Solicitacao> DeleteSolicitacaoAsync(long codigoSolicitacao);
    }
}
