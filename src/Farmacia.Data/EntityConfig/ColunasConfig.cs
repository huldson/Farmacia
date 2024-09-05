using Farmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Data.EntityConfig
{
    public class ColunasConfig : IEntityTypeConfiguration<Colunas>
    {
        public void Configure(EntityTypeBuilder<Colunas> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(50);
        }
    }
}
