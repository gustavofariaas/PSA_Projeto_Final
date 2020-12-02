using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades.Modelos
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string CategoriaNome { get; set; }

    }
}
