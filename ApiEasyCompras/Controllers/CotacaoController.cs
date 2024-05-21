using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YourNamespace.Models;
using YourNamespace.DTOs;
using YourNamespace.Data;

[ApiController]
[Route("api/[controller]")]
public class CotacaoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CotacaoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Cadastrar([FromBody] DadosCadastroCotacao dados)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var cotacao = new Cotacao(dados);
        _context.Cotacoes.Add(cotacao);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Listar([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var cotacoes = await _context.Cotacoes
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(c => new DadosListagemCotacao(c))
            .ToListAsync();

        return Ok(cotacoes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(long id)
    {
        var cotacao = await _context.Cotacoes.FindAsync(id);
        if (cotacao == null)
        {
            return NotFound();
        }

        return Ok(new DadosListagemCotacao(cotacao));
    }

    [HttpPut]
    public async Task<IActionResult> Atualizar([FromBody] DadosAtualizacaoCotacao dados)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var cotacao = await _context.Cotacoes.FindAsync(dados.CodigoCotacao);
        if (cotacao == null)
        {
            return NotFound();
        }

        cotacao.Atualizar(dados);
        _context.Entry(cotacao).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Excluir(long id)
    {
        var cotacao = await _context.Cotacoes.FindAsync(id);
        if (cotacao == null)
        {
            return NotFound();
        }

        _context.Cotacoes.Remove(cotacao);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
