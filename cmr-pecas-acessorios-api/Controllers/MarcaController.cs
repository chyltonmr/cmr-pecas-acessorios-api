using Microsoft.AspNetCore.Mvc;
using System.Data;
using Dapper;
using MySqlConnector;
using Cmr.Pecas.Acessorios.Service;
using Cmr.Pecas.Acessorios.Service.Services;
using System.Threading.Tasks;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Domain.DTO;

namespace cmr_pecas_acessorios_api.Controllers;

[ApiController]
[Route("")]
public class MarcaController : ControllerBase
{
    private readonly MarcaService _marcaService;
    private readonly CategoriaService _categoriaService;

    private readonly ILogger<MarcaController> _logger;

    public MarcaController(ILogger<MarcaController> logger, MarcaService marcaService)
    {
        _logger = logger;
        _marcaService = marcaService;
    }


    [HttpGet]
    [Route("marcas")]
    public async Task<PagedResult<ObterMarcasDto>> Get([FromQuery] int pageNumber, [FromQuery] int pageSize)
    {

        PagedResult<ObterMarcasDto> resp = await _marcaService.GetAll(pageNumber, pageSize);

        return resp;
    }
}
