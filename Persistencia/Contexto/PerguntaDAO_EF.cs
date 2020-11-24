using Entidades.POCO;
using Microsoft.EntityFrameworkCore;
using Persistencia.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Repositorios
{
    public class PerguntaDAO_EF : Crud_EF<Pergunta>, IPergunta

    {
        private readonly DbContextOptions<DatabaseContext> _optionsbuilder;

        public PerguntaDAO_EF()
        {
            _optionsbuilder = new DbContextOptions<DatabaseContext>();
        }
    }
}
