using Entidades.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    public class ProdutoDAO_EF : Crud_EF<Produto>, IProduto

    {
        private readonly DbContextOptions<DatabaseContext> _optionsbuilder;

        public ProdutoDAO_EF()
        {
            _optionsbuilder = new DbContextOptions<DatabaseContext>();
        }
    }
}
