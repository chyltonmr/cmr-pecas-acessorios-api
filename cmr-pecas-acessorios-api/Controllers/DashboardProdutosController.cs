using Cmr.Pecas.Acessorios.Domain.DTO;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Service;
using Cmr.Pecas.Acessorios.Service.BFF;
using Cmr.Pecas.Acessorios.Service.Services;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;
using System.Threading.Tasks;

namespace cmr_pecas_acessorios_api.Controllers;

[ApiController]
[Route("")]
public class DashboardProdutosController : ControllerBase
{
    private readonly ProdutoService _produtoService;
    private readonly CategoriaService _categoriaService;
    private readonly UseCaseAtualizarInfoProdutos _useCaseAtualizarInfoProdutos;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<DashboardProdutosController> _logger;

    public DashboardProdutosController(ILogger<DashboardProdutosController> logger, ProdutoService produtoService, CategoriaService categoriaService, UseCaseAtualizarInfoProdutos useCaseAtualizarInfoProdutos)
    {
        _logger = logger;
        _produtoService = produtoService;
        _categoriaService = categoriaService;
        _useCaseAtualizarInfoProdutos = useCaseAtualizarInfoProdutos;
    }


    [HttpGet]
    [Route("produtos")]
    public async Task<PagedResult<ObterTodosProdutosDto>> Get([FromQuery] int pageNumber, [FromQuery] int pageSize)
    {

        PagedResult<ObterTodosProdutosDto> resp = await _produtoService.GetAll(pageNumber, pageSize);

        return resp;
    }

    [HttpPatch]
    [Route("produto/atualizar/{id:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] ObterTodosProdutosDto produto)
    {
       
        //await _produtoService.Update(produto);
        await _useCaseAtualizarInfoProdutos.Update(produto);

        return StatusCode(200, produto);
    }

    [HttpGet]
    [Route("categorias")]
    public async Task<PagedResult<ObterCategoriasDto>> Get()
    {

        PagedResult<ObterCategoriasDto> resp = await _categoriaService.GetAll(1, 14);

        return resp;
    }
}
