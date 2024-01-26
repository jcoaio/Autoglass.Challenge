using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Infra
{
    public class AutoglassDbContext : DbContext
    {

        public AutoglassDbContext(DbContextOptions<AutoglassDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Fornecedor>(new FornecedorMap().Configure);

            base.OnModelCreating(modelBuilder);

        }
    }
}