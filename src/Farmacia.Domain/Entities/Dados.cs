using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Domain.Entities
{
    public class Dados :Entity
    {
        public string Valor { get; set; }

        public Guid Agrupador { get; set; }
        
        public int ColunaId {  get; set; }
        
        public virtual ICollection<Colunas> Colunas { get; set; }
    }
}
