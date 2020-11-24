using Entidades.Model;
using Microsoft.EntityFrameworkCore;
using Persistencia.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Repositorios
{
    public class UsuarioDAO_EF : Crud_EF<Usuario>, IUsuario

    {
        private readonly DbContextOptions<DatabaseContext> _optionsbuilder;

        public UsuarioDAO_EF()
        {
            _optionsbuilder = new DbContextOptions<DatabaseContext>();
        }
    }
}
