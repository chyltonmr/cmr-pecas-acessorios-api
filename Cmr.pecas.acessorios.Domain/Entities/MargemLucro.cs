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


    public async Task<List<MargemLucro>> MapMargemLucro(List<Produto> produtos)
    {
        return await Task.Run(() =>
        {
            var response = new List<MargemLucro>();
            foreach (var produto in produtos)
            {
                if (produto.precos != null)
                {
                    foreach (var preco in produto.precos)
                    {
                        if (preco.margemLucro != null)
                        {
                            response.Add(new MargemLucro
                            {
                                id = preco.margemLucro.id,
                                porcentagem_pj = preco.margemLucro.porcentagem_pj,
                                porcentagem_pf = preco.margemLucro.porcentagem_pf,
                                valor_liquido_pj = preco.margemLucro.valor_liquido_pj,
                                valor_liquido_pf = preco.margemLucro.valor_liquido_pf,
                                id_preco = preco.margemLucro.id_preco,
                                //data_insercao = preco.margemLucro.data_insercao, //TODO: Data de 'data_insercao' nao sera atualizada aqui ?
                                //data_desativacao = preco.margemLucro.data_desativacao //TODO: Data de 'data_insercao' nao sera atualizada aqui ?
                            });
                        }
                    }
                }
            }
            return response;
        });
    }


    public async Task<MargemLucro> CalcularValoresLiquidosEmLote(MargemLucro margens, decimal clientePf, decimal clientePj, decimal custo)
    {
        margens.valor_liquido_pf = clientePf - custo;
        margens.valor_liquido_pj = clientePj - custo;

        await CalcularPorcentagensEmLote(margens, clientePf, clientePj);

        return await Task.FromResult(margens);
    }


    #region Metodo privados
    private async Task CalcularPorcentagensEmLote(MargemLucro margemLucro, decimal clientePf, decimal clientePj)
    {
        margemLucro.porcentagem_pf = (margemLucro.valor_liquido_pf / clientePf) * 100;
        margemLucro.porcentagem_pj = (margemLucro.valor_liquido_pj / clientePj) * 100;

        await Task.FromResult(margemLucro);
    }

    #endregion

}
