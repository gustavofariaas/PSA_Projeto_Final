using Entidades.Modelos;
using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Interfaces;
using PersistenceLayer.Repositorisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersistenceLayer.Entidades
{
    public class CrudProdutoEF : CrudEF<Produto>, ICrudProduto
    {


        private readonly DbContextOptions<Context> _optionsbuilder;

        public CrudProdutoEF()
        {
            _optionsbuilder = new DbContextOptions<Context>();
        }

        public int getProdutos()
        {
            using (var data = new Context(_optionsbuilder))
            {
                return data.Produtos.Where(t=>t.ProdutoNome == "Playstation 4").Count();
            }
        }
    }

}
