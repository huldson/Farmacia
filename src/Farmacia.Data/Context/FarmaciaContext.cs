using Farmacia.Data.EntityConfig;
using Farmacia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Data.Context
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
        {


        }

        public DbSet<Industria> Industria { get; set; }

        public DbSet<Colunas> Colunas { get; set; }

        public DbSet<Dados> Dados { get; set; }

        public DbSet<Tabelas> Tabelas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IndustriaConfig());
            modelBuilder.ApplyConfiguration(new DadosConfig());
            modelBuilder.ApplyConfiguration(new TabelasConfig());
            modelBuilder.ApplyConfiguration(new ColunasConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
