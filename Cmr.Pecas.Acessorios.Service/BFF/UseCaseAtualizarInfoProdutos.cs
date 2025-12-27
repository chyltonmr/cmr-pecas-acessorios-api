using Cmr.Pecas.Acessorios.Domain.DTO;
using Cmr.Pecas.Acessorios.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.BFF
{
    public class UseCaseAtualizarInfoProdutos
    {
        private readonly ProdutoService _produtoService;
        private readonly MargemLucroService _margemLucroService;
        private readonly CustoService _custoService;
        public UseCaseAtualizarInfoProdutos(ProdutoService produtoService, MargemLucroService margemLucro, CustoService custoService)
        {
            _produtoService = produtoService;
            _margemLucroService = margemLucro;
            _custoService = custoService;
        }
        public async Task Update(ObterTodosProdutosDto obterTodosProdutosDto)
        {
            var respMap = await obterTodosProdutosDto.MapParaProduto(new List<ObterTodosProdutosDto>() { obterTodosProdutosDto });
            var produto = respMap.FirstOrDefault();

            var custos = await _custoService.GetByProdutoId(produto.id);

            var valorCustos = custos.Where(x => x.id != obterTodosProdutosDto.custo.id)
                                   .Sum(x => x.custo);

            if (valorCustos != default)
                obterTodosProdutosDto.custo.custo += valorCustos;

            await _margemLucroService.Update(obterTodosProdutosDto);

            await _produtoService.Update(obterTodosProdutosDto);
        }
    }
}
