using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class CustoRepository : DatabaseContext, ICustoRepository
    {
        private IDbConnection _db;

        public CustoRepository(IOptionsSnapshot<ConnectionString> conectionString)
            : base(conectionString)
        {
            _db = CreateConnection();
        }

        /// <summary>
        /// Retorna todos os custos ATIVOS de um produto
        /// </summary>
        public async Task<List<Custo>> GetByProdutoId(Guid idProduto)
        {
            const string sql = @"
                SELECT
                    id,
                    id_produto,
                    nome,
                    descricao,
                    custo,
                    data_insercao,
                    data_desativacao
                FROM custo
                WHERE id_produto = @idProduto
                  AND data_desativacao IS NULL
                ORDER BY data_insercao DESC;
            ";

            var result = await _db.QueryAsync<Custo>(sql, new { idProduto });

            return result.AsList();
        }

        public async Task Save(Custo custo, IDbTransaction dbTransaction)
        {
            IDbTransaction _dbTransaction = dbTransaction ?? _db.BeginTransaction();

            const string sql = @"
                INSERT INTO custo
                (
                    id,
                    id_produto,
                    nome,
                    descricao,
                    custo,
                    data_insercao,
                    data_desativacao
                )
                VALUES
                (
                    @id,
                    @id_produto,
                    @nome,
                    @descricao,
                    @custo,
                    @data_insercao,
                    @data_desativacao
                );
            ";

            try
            {
                await _db.ExecuteAsync(sql, custo, _dbTransaction);
                _dbTransaction.Commit();
            }
            catch
            {
                _dbTransaction.Rollback();
                throw;
            }
        }

        public async Task Update(Custo custo, IDbTransaction dbTransaction)
        {
            IDbTransaction _dbTransaction = dbTransaction ?? _db.BeginTransaction();

            const string sql = @"
                UPDATE custo
                SET
                    nome = @nome,
                    descricao = @descricao,
                    custo = @custo,
                    data_desativacao = @data_desativacao
                WHERE id = @id;
            ";

            try
            {
                await _db.ExecuteAsync(sql, custo, _dbTransaction);
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
