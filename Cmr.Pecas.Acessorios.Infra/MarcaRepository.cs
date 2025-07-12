using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class MarcaRepository : DatabaseContext, IMarcaRepository
    {
        private readonly IDbConnection _db;
        public MarcaRepository(IOptionsSnapshot<ConnectionString> conectionString) : base(conectionString)
        {
            _db = CreateConnection();
        }


        public async Task<PagedResult<Marca>> GetAll(int pageNumber, int pageSize)
        {
            var offset = (pageNumber - 1) * pageSize;

            // Consulta de dados de categoria com paginação
            var sql = @"
                    SELECT 
                        m.*
                    FROM marca m
                    ORDER BY m.nome
                    LIMIT @PageSize OFFSET @Offset;
                    ";

            // Executa a query e materializa só marca
            var marcas = await _db.QueryAsync<Marca>(
                sql,
                new { Offset = offset, PageSize = pageSize }
            );

            // Consulta de contagem total de marca
            const string countSql = "SELECT COUNT(*) FROM marca";
            var totalItems = await _db.ExecuteScalarAsync<int>(countSql);

            return new PagedResult<Marca>
            {
                // Atenção: ajusta o nome da propriedade conforme seu PagedResult<T>
                ListObjetos = marcas.ToList(),
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public Task<Marca> GetById(int marcaId)
        {
            throw new NotImplementedException();
        }

        public void Save(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Update(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
