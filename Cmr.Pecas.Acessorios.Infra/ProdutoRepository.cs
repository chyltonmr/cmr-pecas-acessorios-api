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


        public async Task<PagedResult<Produto>> GetAll(int pageNumber, int pageSize)
        {
            var offset = (pageNumber - 1) * pageSize;

            // Consulta de dados com paginação
            var sql = @"
        SELECT 
            p.*, 
            c.*, 
            m.*, 
            pr.*, 
            tp.*, 
            ml.*, 
            cu.*
        FROM produto p
        JOIN categoria c ON p.id_categoria = c.id
        JOIN marca m ON p.id_marca = m.id
        JOIN preco pr ON pr.id_produto = p.id
        JOIN tipo_preco tp ON pr.id_tipo_preco = tp.id
        LEFT JOIN margem_lucro ml ON ml.id_preco = pr.id
        LEFT JOIN custo cu ON cu.id_produto = p.id
        ORDER BY p.nome
        LIMIT @PageSize OFFSET @Offset;
    ";

            var produtoDictionary = new Dictionary<Guid, Produto>();

            var result = await _db.QueryAsync<Produto, Categoria, Marca, Preco, TipoPreco, MargemLucro, Custo, Produto>(
                sql,
                (produto, categoria, marca, preco, tipoPreco, margemLucro, custo) =>
                {
                    if (!produtoDictionary.TryGetValue(produto.id, out var produtoEntry))
                    {
                        produtoEntry = produto;
                        produtoEntry.categoria = categoria;
                        produtoEntry.marca = marca;
                        produtoEntry.precos = new List<Preco>();
                        produtoEntry.custo = custo;

                        produtoDictionary.Add(produtoEntry.id, produtoEntry);
                    }

                    preco.tipoPreco = tipoPreco;
                    preco.margemLucro = margemLucro;
                    produtoEntry.precos.Add(preco);

                    return produtoEntry;
                },
                new { Offset = offset, PageSize = pageSize },
                splitOn: "id,id,id,id,id,id,id"
            );

            // Consulta de contagem total
            var countSql = "SELECT COUNT(*) FROM produto";
            var totalItems = await _db.ExecuteScalarAsync<int>(countSql);

            return new PagedResult<Produto>
            {
                Produtos = produtoDictionary.Values.ToList(),
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
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
