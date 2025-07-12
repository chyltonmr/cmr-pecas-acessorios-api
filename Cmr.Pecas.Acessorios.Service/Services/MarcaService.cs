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
    public class MarcaService
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public async Task<PagedResult<ObterMarcasDto>> GetAll(int pageNumber, int pageSize)
        {
            PagedResult<Marca> response = await _marcaRepository.GetAll(pageNumber, pageSize);
            var marcas = response.ListObjetos.ToList();
            var marcasDto = await new ObterMarcasDto().MapObterMarcasDto(marcas);
            var pagResult = new PagedResult<ObterMarcasDto>
            {
                ListObjetos = marcasDto,
                TotalItems = response.TotalItems,
                PageNumber = response.PageNumber,
                PageSize = response.PageSize
            };

            return pagResult;
        }

        public Task<Marca> GetById(int marcaId)
        {
            throw new NotImplementedException();
        }

        public void Save(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Update(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
