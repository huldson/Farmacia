using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Domain.Entities
{
    public class Industria : Entity
    {       
        public string Nome { get; set; } 
        
        public virtual ICollection<Tabelas> Tabelas { get; set; }
    }
}
