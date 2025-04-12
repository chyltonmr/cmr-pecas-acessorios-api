public class Custo
{
    public Guid id { get; set; }
    public Guid id_produto { get; set; }
    public string nome { get; set; }
    public string descricao { get; set; }
    public decimal custo { get; set; }
    public DateTime data_insercao { get; set; }
    public DateTime data_desativacao { get; set; }
}
