using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class CategoriaRepository : DatabaseContext, ICategoriaRepository
    {
        private readonly IDbConnection _db;
        public CategoriaRepository(IOptionsSnapshot<ConnectionString> conectionString) : base(conectionString)
        {
            _db = CreateConnection();
        }


        public async Task<PagedResult<Categoria>> GetAll(int pageNumber, int pageSize)
        {
            var offset = (pageNumber - 1) * pageSize;

            // Consulta de dados de categoria com paginação
            var sql = @"
                    SELECT 
                        c.*
                    FROM categoria c
                    ORDER BY c.nome
                    LIMIT @PageSize OFFSET @Offset;
                    ";

            // Executa a query e materializa só Categoria
            var categorias = await _db.QueryAsync<Categoria>(
                sql,
                new { Offset = offset, PageSize = pageSize }
            );

            // Consulta de contagem total de categorias
            const string countSql = "SELECT COUNT(*) FROM categoria";
            var totalItems = await _db.ExecuteScalarAsync<int>(countSql);

            return new PagedResult<Categoria>
            {
                // Atenção: ajusta o nome da propriedade conforme seu PagedResult<T>
                ListObjetos = categorias.ToList(),
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }





        public Task<Categoria> GetById(int produtoId)
        {
            throw new NotImplementedException();
        }

        public void Save(Categoria produto)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria produto)
        {
            throw new NotImplementedException();
        }
    }
}
