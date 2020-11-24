using Entidades.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.POCO
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public Usuario Comprador { get; set; }
        public Produto Produto { get; set; }
        public string Descricao { get; set; }
        public string Resposta { get; set; }
    }
}
