
using Cmr.Pecas.Acessorios.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Repositories
{
    public interface IProdutoRepository
    {
        public Task Save(Produto produto);
        public Task Update(Produto produto);
        public Task<Produto> GetById(int produtoId);
        public Task<PagedResult<Produto>> GetAll(int pageNumber, int pageSize);
    }
}
