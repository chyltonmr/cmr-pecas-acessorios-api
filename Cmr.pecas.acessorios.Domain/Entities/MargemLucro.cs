public class MargemLucro
{
    public Guid id { get; set; }
    public decimal porcentagem_pj { get; set; }
    public decimal porcentagem_pf { get; set; }
    public decimal valor_liquido_pj { get; set; }
    public decimal valor_liquido_pf { get; set; }
    public Guid id_preco { get; set; }
    public DateTime data_insercao { get; set; }
    public DateTime data_desativacao { get; set; }
}