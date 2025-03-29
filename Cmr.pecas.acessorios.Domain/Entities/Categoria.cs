using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Entities
{
    public class Categoria
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public DateTime data_insercao { get; set; }
        public DateTime? data_desativacao { get; set; }
    }

}
