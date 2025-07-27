using Cmr.Pecas.Acessorios.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Service.Services
{
    public class MargemLucroService
    {
        private readonly IMargemLucroRepository _margemLucroRepository;

        public MargemLucroService(IMargemLucroRepository margemLucroRepository)
        {
            _margemLucroRepository = margemLucroRepository;
        }

        public async Task Update(List<MargemLucro> margemLucro, IDbTransaction dbTransaction)
        {
            await _margemLucroRepository.Update(margemLucro, dbTransaction);
        }
    }
}
