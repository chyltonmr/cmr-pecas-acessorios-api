using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _estoqueRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _estoqueRepository = produtoRepository;
        }
        public async Task<PagedResult<ObterTodosProdutosDto>> GetAll(int pageNumber, int pageSize)
        {
            PagedResult<Produto> response = await _estoqueRepository.GetAll(pageNumber, pageSize);
            var produtos = response.ListObjetos.ToList();
            var produtosDto = await new ObterTodosProdutosDto().MapObterTodosProduto(produtos);
            var pagResult = new PagedResult<ObterTodosProdutosDto>
            {
                ListObjetos = produtosDto,
                TotalItems = response.TotalItems,
                PageNumber = response.PageNumber,
                PageSize = response.PageSize
            };
            return pagResult;
        }

        public async Task Update(Produto produto)
        {
           _estoqueRepository.Update(produto);
        }
    }
}
