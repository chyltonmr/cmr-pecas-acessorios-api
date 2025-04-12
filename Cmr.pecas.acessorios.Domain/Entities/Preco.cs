public class Preco
{
    public Guid id { get; set; }
    public Guid id_produto { get; set; }
    public Guid id_tipo_preco { get; set; }
    public decimal preco { get; set; }
    public DateTime data_insercao { get; set; }
    public DateTime? data_desativacao { get; set; }
    public string observacao { get; set; }

    public TipoPreco tipoPreco { get; set; }
    public MargemLucro margemLucro { get; set; }


}