using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades.Modelos
{
    public class Venda
    {
        public int VendaID { get; set; }
        public int DiasAposPost { get; set; }
        public bool isSold { get; set; }

        [ForeignKey("ProdutoID")]
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Status Status { get; set; }

    }
}
