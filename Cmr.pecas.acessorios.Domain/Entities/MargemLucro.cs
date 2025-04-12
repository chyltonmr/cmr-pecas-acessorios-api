public class MargemLucro
{
    public Guid id { get; set; }
    public decimal porcentagem { get; set; }
    public Guid id_preco { get; set; }
    public DateTime data_insercao { get; set; }
    public DateTime data_desativacao { get; set; }
}