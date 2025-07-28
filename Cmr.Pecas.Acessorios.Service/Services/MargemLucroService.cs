using Cmr.Pecas.Acessorios.Domain.DTO;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.Services
{
    public class MargemLucroService
    {
        private readonly IMargemLucroRepository _margemLucroRepository;

        public MargemLucroService(IMargemLucroRepository margemLucroRepository)
        {
            _margemLucroRepository = margemLucroRepository;
        }

        public async Task Update(ObterTodosProdutosDto obterTodosProdutosDto, IDbTransaction? dbTransaction = null)
        {
            MargemLucro margemLucro = obterTodosProdutosDto.precos.margemLucro;

            margemLucro = await margemLucro.CalcularValoresLiquidosEmLote(margemLucro, obterTodosProdutosDto.precos.preco_pf, obterTodosProdutosDto.precos.preco_pj, obterTodosProdutosDto.custo.custo);

            await _margemLucroRepository.Update(margemLucro, dbTransaction);
        }
    }
}
