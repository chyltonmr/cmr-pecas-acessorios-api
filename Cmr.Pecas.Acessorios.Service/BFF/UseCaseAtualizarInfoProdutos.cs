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
        public UseCaseAtualizarInfoProdutos(ProdutoService produtoService, MargemLucroService margemLucro)
        { 
            _produtoService = produtoService;
            _margemLucroService = margemLucro;
        }
        public async Task Update(ObterTodosProdutosDto obterTodosProdutosDto)
        {
            var respMap = await obterTodosProdutosDto.MapParaProduto(new List<ObterTodosProdutosDto>() { obterTodosProdutosDto });
            var produto = respMap.FirstOrDefault();

          await  _margemLucroService.Update(obterTodosProdutosDto);

            await _produtoService.Update(obterTodosProdutosDto);
        }
    }
}
