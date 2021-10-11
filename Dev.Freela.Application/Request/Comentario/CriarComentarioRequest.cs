using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Request.Comentario
{
   public  class CriarComentarioRequest
    {
        public string Conteudo { get; set; }

        public int IdUsuario { get; set; }

        public int IdProjeto { get; set; }
    }
}
