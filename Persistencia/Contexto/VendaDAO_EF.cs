using Entidades.Model;
using Microsoft.EntityFrameworkCore;
using Persistencia.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    public class VendaDAO_EF : Crud_EF<Venda>, IVenda

    {
        private readonly DbContextOptions<DatabaseContext> _optionsbuilder;

        public VendaDAO_EF()
        {
            _optionsbuilder = new DbContextOptions<DatabaseContext>();
        }
    }
}
