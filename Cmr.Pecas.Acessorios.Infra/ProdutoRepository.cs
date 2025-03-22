using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class ProdutoRepository : DatabaseConnection, IProdutoRepository
    {
        private readonly IDbConnection _db;
        public ProdutoRepository(IOptionsSnapshot<ConnectionString> conectionString) : base(conectionString)
        {
            _db = CreateConnection();
        }

        public Task<List<Produto>> GetAll()
        {
            var clientes = _db.Query<object>("SELECT * FROM city");

            throw new NotImplementedException();
        }

        public Task<Produto> GetById(int produtoId)
        {
            throw new NotImplementedException();
        }

        public void Save(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
