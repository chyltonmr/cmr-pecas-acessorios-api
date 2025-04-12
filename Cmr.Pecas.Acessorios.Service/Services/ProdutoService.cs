using Cmr.Pecas.Acessorios.Domain.Repositories;
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
        public async Task<PagedResult<Produto>> GetAll(int pageNumber, int pageSize)
        {
            PagedResult<Produto> response = await _estoqueRepository.GetAll(pageNumber, pageSize);
            return response;
        }
    }
}
