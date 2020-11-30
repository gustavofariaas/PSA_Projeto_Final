using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades.Modelos
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Local { get; set; }
        
        //[ForeignKey("CategoriaID")]
        //public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
