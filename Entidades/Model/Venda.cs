using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Model
{
    public class Venda
    {
        public int VendaID { get; set; }
        public int DiasAposPost { get; set; }
        public bool isSold { get; set; }

        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }

        public int VendedorID { get; set; }
        

    }
}
