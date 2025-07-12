
using Cmr.Pecas.Acessorios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Repositories
{
    public interface IMarcaRepository
    {
        public void Save(Marca marca);
        public void Update(Marca marca);
        public Task<Marca> GetById(int marcaId);
        public Task<PagedResult<Marca>> GetAll(int pageNumber, int pageSize);
    }
}
