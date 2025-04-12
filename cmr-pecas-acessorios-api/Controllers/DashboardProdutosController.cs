using Microsoft.AspNetCore.Mvc;
using System.Data;
using Dapper;
using MySqlConnector;
using Cmr.Pecas.Acessorios.Service;
using Cmr.Pecas.Acessorios.Service.Services;
using System.Threading.Tasks;

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
    public async Task<Produto>Get()
    {

        var dd = await _produtoService.GetAll();

        return dd.FirstOrDefault();
    }
}
