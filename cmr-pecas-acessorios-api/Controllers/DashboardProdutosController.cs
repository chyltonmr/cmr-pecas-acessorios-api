using Microsoft.AspNetCore.Mvc;
using System.Data;
using Dapper;
using MySqlConnector;
using Cmr.Pecas.Acessorios.Service;
using Cmr.Pecas.Acessorios.Service.Services;
using System.Threading.Tasks;
using Cmr.Pecas.Acessorios.Domain.Repositories;

namespace cmr_pecas_acessorios_api.Controllers;

[ApiController]
[Route("")]
public class DashboardProdutosController : ControllerBase
{
    private readonly ProdutoService _produtoService;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<DashboardProdutosController> _logger;

    public DashboardProdutosController(ILogger<DashboardProdutosController> logger, ProdutoService produtoService)
    {
        _logger = logger;
        _produtoService = produtoService;
    }


    [HttpGet]
    [Route("produtos")]
    public async Task<PagedResult<Produto>> Get([FromQuery] int pageNumber,[FromQuery] int pageSize)
    {

        PagedResult<Produto> resp = await _produtoService.GetAll(pageNumber, pageSize);

        return resp;
    }
}
