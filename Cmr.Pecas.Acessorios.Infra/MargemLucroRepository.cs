using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.X509;
using System.Data;
using System.Data.Common;
using System.Transactions;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class MargemLucroRepository : DatabaseContext, IMargemLucroRepository
    {
        private IDbConnection _db;
        public MargemLucroRepository(IOptionsSnapshot<ConnectionString> conectionString) : base(conectionString)
        {
            _db = CreateConnection();
        }

        public Task<PagedResult<List<MargemLucro>>> GetAll(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<MargemLucro> GetById(int margemLucro)
        {
            throw new NotImplementedException();
        }

        public Task Save(MargemLucro margemLucro)
        {
            throw new NotImplementedException();
        }

        public async Task Update(MargemLucro margemLucro, IDbTransaction dbTransaction)
        {
            IDbTransaction _dbTransaction = dbTransaction ?? _db.BeginTransaction();

            const string sql = @"
            UPDATE margem_lucro
            SET 
                porcentagem_pj = @porcentagem_pj,
                porcentagem_pf = @porcentagem_pf,
                valor_liquido_pj = @valor_liquido_pj,
                valor_liquido_pf = @valor_liquido_pf

            WHERE id = @id;
        ";

            try
            {
                await _db.ExecuteAsync(sql, margemLucro, _dbTransaction);

                _dbTransaction.Commit();
            }
            catch
            {
                _dbTransaction.Rollback();
                throw;
            }
        }
    }
}
