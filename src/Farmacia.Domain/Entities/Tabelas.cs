using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Domain.Entities
{
    public class Tabelas: Entity
    {        
        public string Name { get; set; }

        public int IndustriaId { get; set; }

        public virtual Industria Industria { get; set; }
    }
}
