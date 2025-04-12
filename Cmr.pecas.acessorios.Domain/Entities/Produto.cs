using Cmr.Pecas.Acessorios.Domain.Entities;
using System;

public class Produto
{
    public Guid id { get; set; }
    public string nome { get; set; }
    public string descricao { get; set; }
    public int estoque { get; set; }
    public Guid id_categoria { get; set; }
    public Guid id_marca { get; set; }
    public DateTime data_insercao { get; set; }
    public DateTime? data_desativacao { get; set; }

    public Categoria categoria { get; set; }
    public Marca marca { get; set; }
    public List<Preco> precos { get; set; } = new();

    //public MargemLucro margemLucro { get; set; }
    public Custo custo { get; set; }
    //public TipoPreco tipoPreco { get; set; }
    //public PrecoPersonalizado precoPersonalizado { get; set; }
    //public TipoPreco tipoPrecoPersonalizado { get; set; }
    //public MargemLucroPersonalizado margemLucroPersonalizada { get; set; }
}
