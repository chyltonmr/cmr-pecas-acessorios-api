using Cmr.Pecas.Acessorios.Domain.Repositories;

namespace Cmr.Pecas.Acessorios.Infra
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task<List<Produto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetById(int produtoId)
        {
            throw new NotImplementedException();
        }

        public void Save(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
