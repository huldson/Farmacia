using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DtInicioVigencia { get; set; }

        public DateTime DtFimVigencia { get; set; }
    }
}
