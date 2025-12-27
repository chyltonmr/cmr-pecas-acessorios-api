using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.Services
{
    public class CustoService
    {
        private readonly ICustoRepository _custoRepository;

        public CustoService(ICustoRepository custoRepository)
        {
            _custoRepository = custoRepository;
        }

        /// <summary>
        /// Retorna todos os custos ativos de um produto
        /// </summary>
        public async Task<List<Custo>> GetByProdutoId(Guid idProduto)
        {
            return await _custoRepository.GetByProdutoId(idProduto);
        }

        /// <summary>
        /// Salva um novo custo para um produto
        /// </summary>
        public async Task Save(Custo custo, IDbTransaction? dbTransaction = null)
        {
            custo.id = Guid.NewGuid();
            custo.data_insercao = DateTime.Now;
            custo.data_desativacao = null;

            await _custoRepository.Save(custo, dbTransaction);
        }

        /// <summary>
        /// Atualiza um custo existente
        /// </summary>
        public async Task Update(Custo custo, IDbTransaction? dbTransaction = null)
        {
            await _custoRepository.Update(custo, dbTransaction);
        }

        /// <summary>
        /// Desativa (soft delete) um custo
        /// </summary>
        public async Task Desativar(Guid idCusto, IDbTransaction? dbTransaction = null)
        {
            var custo = new Custo
            {
                id = idCusto,
                data_desativacao = DateTime.Now
            };

            await _custoRepository.Update(custo, dbTransaction);
        }
    }
}
