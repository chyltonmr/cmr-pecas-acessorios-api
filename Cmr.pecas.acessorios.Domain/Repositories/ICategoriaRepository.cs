
using Cmr.Pecas.Acessorios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        public void Save(Categoria produto);
        public void Update(Categoria produto);
        public Task<Categoria> GetById(int CategoriaId);
        public Task<PagedResult<Categoria>> GetAll(int pageNumber, int pageSize);
    }
}
