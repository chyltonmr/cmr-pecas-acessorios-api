
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Repositories
{
    public interface IProdutoRepository
    {
        public void Save(Produto produto);
        public void Update(Produto produto);
        public Task<Produto> GetById(int produtoId);
        public Task<PagedResult<Produto>> GetAll(int pageNumber, int pageSize);
    }
}
