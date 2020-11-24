using Entidades.Model;
using Entidades.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Repositorios
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> _OptionsBuilder) : base()
        { }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Pergunta> Pergunta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

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
