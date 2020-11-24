using Entidades.Model;
using Microsoft.EntityFrameworkCore;
using Persistencia.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    public class CategoriaDAO_EF : Crud_EF<Categoria>, ICategoria

    {
        private readonly DbContextOptions<DatabaseContext> _optionsbuilder;

        public CategoriaDAO_EF()
        {
            _optionsbuilder = new DbContextOptions<DatabaseContext>();
        }
    }
}
