using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Domain.Entities
{
    public class PrecoPersonalizado
    {
        public Guid id { get; set; }
        public Guid id_cliente { get; set; }
        public Guid id_produto { get; set; }
        public Guid id_tipo_preco { get; set; }
        public decimal preco { get; set; }
        public DateTime data_insercao { get; set; }
        public DateTime? data_desativacao { get; set; }
        public string observacao { get; set; }
    }

}
