using Entidades.POCO;
using Microsoft.EntityFrameworkCore;
using Persistencia.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Repositorios
{
    public class AvaliacaoDAO_EF : Crud_EF<Avaliacao>, IAvaliacao

    {
        private readonly DbContextOptions<DatabaseContext> _optionsbuilder;

        public AvaliacaoDAO_EF()
        {
            _optionsbuilder = new DbContextOptions<DatabaseContext>();
        }
    }
}
