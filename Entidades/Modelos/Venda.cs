using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades.Modelos
{
    public class Venda
    {
        public int VendaID { get; set; }
        public string DescricaoVenda { get; set; }
        
        public virtual ApplicationUser Usuario { get; set; }

        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
        public int StatusID { get; set; }
        public virtual Status Status { get; set; }

        public bool isSold { get; set; }

    }
}
