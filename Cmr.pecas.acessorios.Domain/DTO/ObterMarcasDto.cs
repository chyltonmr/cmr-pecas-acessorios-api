using Cmr.Pecas.Acessorios.Domain.Entities;


namespace Cmr.Pecas.Acessorios.Domain.DTO
{
    public class ObterMarcasDto
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public DateTime data_insercao { get; set; }
        public DateTime? data_desativacao { get; set; }

        public async Task<List<ObterMarcasDto>> MapObterMarcasDto(List<Marca> marcas)
        {
            return await Task.Run(() =>
            {
                var response = new List<ObterMarcasDto>();

                foreach (var produto in marcas)
                {
                    response.Add(new ObterMarcasDto
                    {
                        id = produto.id,
                        nome = produto.nome,
                        data_insercao = produto.data_insercao,
                        data_desativacao = produto.data_desativacao
                    });
                }

                return response;
            });
        }
    }
}
