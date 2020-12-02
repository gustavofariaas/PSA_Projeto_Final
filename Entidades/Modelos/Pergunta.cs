using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelos
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public ApplicationUser Comprador { get; set; }
        public Produto Produto { get; set; }
        public string Descricao { get; set; }
        public string Resposta { get; set; }
    }
}
