using Cmr.Pecas.Acessorios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Repositories
{
    public interface ICustoRepository
    {
        Task<List<Custo>> GetByProdutoId(Guid idProduto);
        Task Save(Custo custo, IDbTransaction dbTransaction);
        Task Update(Custo custo, IDbTransaction dbTransaction);
    }
}
