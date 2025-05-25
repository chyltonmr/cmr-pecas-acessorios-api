using Cmr.Pecas.Acessorios.Domain.Entities;


namespace Cmr.Pecas.Acessorios.Service.DTO
{
    public class ObterCategoriasDto
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public DateTime data_insercao { get; set; }
        public DateTime? data_desativacao { get; set; }

 
        public async Task<List<ObterCategoriasDto>> MapObterTodasAsCategorias(List<Categoria> categorias)
        {
            // Using Task.Run to address CS1998
            return await Task.Run(() =>
            {
                var response = new List<ObterCategoriasDto>();

                foreach (var categoria in categorias)
                {
                    response.Add(new ObterCategoriasDto
                    {
                        id = categoria.id,
                        nome = categoria.nome,
                        data_insercao = categoria.data_insercao,
                        data_desativacao = categoria.data_desativacao,
                    });
                }

                return response;
            });
        }
    }
}
