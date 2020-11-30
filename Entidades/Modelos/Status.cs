using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades.Modelos
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusNome { get; set; }
        

    }
}
