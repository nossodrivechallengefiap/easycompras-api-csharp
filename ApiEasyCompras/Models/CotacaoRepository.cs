using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Entity;

namespace Models
{
    public class CotacaoRepository : ICotacaoRepository
    {
        private readonly EasyComprasContext _context;

        public CotacaoRepository(EasyComprasContext context)
        {
            _context = context;
        }

        public async Task<List<Cotacao>> GetAllCotacoesAsync()
        {
            return await _context.Cotacoes.ToListAsync();
        }

        public async Task<Cotacao> GetCotacaoByIdAsync(long id)
        {
            return await _context.Cotacoes.FindAsync(id);
        }

        public async Task<Cotacao> AddCotacaoAsync(Cotacao cotacao)
        {
            _context.Cotacoes.Add(cotacao);
            await _context.SaveChangesAsync();
            return cotacao;
        }

        public async Task<Cotacao> UpdateCotacaoAsync(long id, Cotacao cotacao)
        {
            if (id != cotacao.CodigoCotacao)
            {
                throw new ArgumentException("ID da cotação fornecida não corresponde ao ID da cotação atual");
            }

            _context.Entry(cotacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CotacaoExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return cotacao;
        }

        public async Task<Cotacao> DeleteCotacaoAsync(long id)
        {
            var cotacao = await _context.Cotacoes.FindAsync(id);
            if (cotacao == null)
            {
                return null;
            }

            _context.Cotacoes.Remove(cotacao);
            await _context.SaveChangesAsync();

            return cotacao;
        }

        private bool CotacaoExists(long id)
        {
            return _context.Cotacoes.Any(e => e.CodigoCotacao == id);
        }
    }
}
