
using Cmr.Pecas.Acessorios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Repositories
{
    public interface IMargemLucroRepository
    {
        public Task Save(MargemLucro margemLucro);
        public Task Update(MargemLucro margemLucro, IDbTransaction? dbTransaction = null);
        public Task<MargemLucro> GetById(int margemLucro);
        public Task<PagedResult<List<MargemLucro>>> GetAll(int pageNumber, int pageSize);
    }
}
