using Cmr.Pecas.Acessorios.Domain.Entities;
using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.Services
{
    public class CategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<PagedResult<ObterCategoriasDto>> GetAll(int pageNumber, int pageSize)
        {
            PagedResult<Categoria> response = await _categoriaRepository.GetAll(pageNumber, pageSize);
            var produtos = response.ListObjetos.ToList();
            var categoriasDto = await new ObterCategoriasDto().MapObterTodasAsCategorias(produtos);
            var pagResult = new PagedResult<ObterCategoriasDto>
            {
                ListObjetos = categoriasDto,
                TotalItems = response.TotalItems,
                PageNumber = response.PageNumber,
                PageSize = response.PageSize
            };
            return pagResult;
        }

        public async Task Update(ObterCategoriasDto categoria)
        {
            //TODO: IMPLEMENTAR
           await Task.FromResult(categoria);
        }
    }
}
