using Cmr.Pecas.Acessorios.Domain.Repositories;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr.Pecas.Acessorios.Infra.Context
{
    public class DatabaseContext : DatabaseConnection
    {
        public DatabaseContext(IOptionsSnapshot<ConnectionString> conectionString) : base(conectionString)
        {
        }
    }
}
