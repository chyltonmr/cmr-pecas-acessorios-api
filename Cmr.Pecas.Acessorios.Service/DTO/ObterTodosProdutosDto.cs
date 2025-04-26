using Cmr.Pecas.Acessorios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.DTO
{
    public class ObterTodosProdutosDto
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string imagem_thumbnail { get; set; }
        public string descricao { get; set; }
        public int estoque { get; set; }
        public Guid id_categoria { get; set; }
        public Guid id_marca { get; set; }
        public DateTime data_insercao { get; set; }
        public DateTime? data_desativacao { get; set; }

        public Categoria categoria { get; set; }
        public Marca marca { get; set; }
        public Preco precos { get; set; }
        public Custo custo { get; set; }

        public ObterTodosProdutosDto() { }

        // Marking the method as static to address CA1822
        public async Task<List<ObterTodosProdutosDto>> MapObterTodosProduto(List<Produto> produtos)
        {
            // Using Task.Run to address CS1998
            return await Task.Run(() =>
            {
                var response = new List<ObterTodosProdutosDto>();

                foreach (var produto in produtos)
                {
                    response.Add(new ObterTodosProdutosDto
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
                        categoria = produto.categoria,
                        marca = produto.marca,
                        precos = produto.precos.First(x => x.data_desativacao == null),
                        custo = produto.custo
                    });
                }

                return response;
            });
        }
    }
}
