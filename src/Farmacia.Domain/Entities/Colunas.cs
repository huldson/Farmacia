using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Domain.Entities
{
    public class Colunas :Entity
    {
        public string Nome { get; set; }

        public int Ordem { get; set; }

        public int TabelasId { get; set; }

        public virtual Tabelas Tabelas { get; set; }
    }
}
