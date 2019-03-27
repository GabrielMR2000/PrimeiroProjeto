using Microsoft.EntityFrameworkCore;
using ProjetoPaulo.Data.Entity;
using ProjetoPaulo.Data.EntityConfig;
using ProjetoPaulo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Batata = ProjetoPaulo.Data.Entity.Batata;
using Carro = ProjetoPaulo.Data.Entity.Carro;
using Exemplo = ProjetoPaulo.Data.Entity.Exemplo;
using Queijo = ProjetoPaulo.Data.Entity.Queijo;
using TipoBatata = ProjetoPaulo.Data.Entity.TipoBatata;

namespace ProjetoPaulo.Data.Context
{
    public class PauloContext : DbContext
    {
        public DbSet<Exemplo> Exemplo { get; set; }
        public DbSet<Batata> Batata { get; set; }
        public DbSet<TipoBatata> TipoBatata { get; set; }
        public DbSet<Queijo> Queijos { get; set; }
        public DbSet<Carro> Carros { get; set; }

        public PauloContext()
        {

        }
        public PauloContext(DbContextOptions<PauloContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BancoApi;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ExemploConfig());
            builder.ApplyConfiguration(new BatataConfig());
            builder.ApplyConfiguration(new TipoBatatConfig());
        }
    }
}
