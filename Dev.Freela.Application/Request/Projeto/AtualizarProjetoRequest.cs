using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Request.Projeto
{
   public  class AtualizarProjetoRequest
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }
       
        public decimal CustoTotal { get; set; }
    }
}
