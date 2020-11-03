using Entidades.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Repositorios
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        { }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Usuario> Vendedor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SecondHandDB;Trusted_Connection=True;");
                base.OnConfiguring(optionsBuilder);
            }
        }

    }
}
