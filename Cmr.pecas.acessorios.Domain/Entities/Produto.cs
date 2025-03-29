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
}
