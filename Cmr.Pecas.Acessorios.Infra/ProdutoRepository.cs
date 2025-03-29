using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class ProdutoRepository : DatabaseContext, IProdutoRepository
    {
        private readonly IDbConnection _db;
        public ProdutoRepository(IOptionsSnapshot<ConnectionString> conectionString) : base(conectionString)
        {
            _db = CreateConnection();
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            var sql = @"
            SELECT 
                p.*,
                c.*,
                m.*
            FROM produto p
            JOIN categoria c ON p.id_categoria = c.id
            JOIN marca m ON p.id_marca = m.id
        ";

            var produtos = await _db.QueryAsync<Produto, Categoria, Marca, Produto>(
                sql,
                (produto, categoria, marca) =>
                {
                    produto.categoria = categoria;
                    produto.marca = marca;
                    return produto;
                },
                splitOn: "id,id"
            );

            return produtos;

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
