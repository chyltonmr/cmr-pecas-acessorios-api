using Cmr.Pecas.Acessorios.Domain.DTO;
using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra.Context;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;
using System.Threading.Tasks;
using System.Transactions;

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
                ListObjetos = produtoDictionary.Values.ToList(),
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }




        public Task<Produto> GetById(int produtoId)
        {
            throw new NotImplementedException();
        }

        public Task Save(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Produto produto)
        {
            using var transaction = _db.BeginTransaction();

            try
            {
                // 1. Produto
                _db.Execute(@"
            UPDATE produto SET
                nome = @nome,
                imagem_thumbnail = @imagem_thumbnail,
                descricao = @descricao,
                estoque = @estoque,
                id_categoria = @id_categoria,
                id_marca = @id_marca,
                data_insercao = @data_insercao,
                data_desativacao = @data_desativacao
            WHERE id = @id
        ", new
                {
                    id = produto.id,
                    nome = produto.nome,
                    imagem_thumbnail = produto.imagem_thumbnail,
                    descricao = produto.descricao,
                    estoque = produto.estoque,
                    id_categoria = produto.id_categoria,
                    id_marca = produto.id_marca,
                    data_insercao = produto.data_insercao,
                    data_desativacao = produto.data_desativacao,
                },
                  transaction);

                // 2. Categoria
                _db.Execute(@"
                    UPDATE categoria SET
                        nome = @nome,
                        id = @id
                        WHERE id = @id
        ", new
                {
                    id = produto.id_categoria,
                    nome = produto.categoria.nome,
                }, transaction);

                // 3. Marca
                _db.Execute(@"
                    UPDATE marca SET
                        nome = @nome,
                        id = @id
                        WHERE Id = @id
        ", new
                {
                    id = produto.id_categoria,
                    nome = produto.categoria.nome,
                }, transaction);

                // 4. Preços (lista)
                foreach (var preco in produto.precos)
                {
                    // 4.1. Preço
                    _db.Execute(@"
                UPDATE preco SET
                    preco_pj = @preco_pj,
                    preco_pf = @preco_pf,
                    observacao = @observacao
                WHERE id = @id
            ", new
                    {
                        id = preco.id,
                        preco_pj = preco.preco_pj,
                        preco_pf = preco.preco_pf,
                        observacao = preco.observacao,
                    }, transaction);

                    // 4.2. Tipo de Preço
                    _db.Execute(@"
                UPDATE tipo_preco SET
                    id = @id,
                    nome = @nome,
                    descricao = @descricao
                    WHERE id = @id
            ", new
                    {
                        id = preco.tipoPreco.id,
                        nome = preco.tipoPreco.nome,
                        descricao = preco.tipoPreco.descricao,
                    }, transaction);


                }

                // 5. Custo
                _db.Execute(@"
                UPDATE custo SET
                    nome = @nome,
                    descricao = @descricao,
                    custo = @custo
                WHERE id = @id
            ", new
                {
                    id = produto.custo.id,
                    nome = produto.custo.nome,
                    descricao = produto.custo.descricao,
                    custo = produto.custo.custo,
                }, transaction);

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
