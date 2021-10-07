using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
   public  class ProjetoComentario :BaseEntity
    {
        public ProjetoComentario(string conteudo, int idProjeto, int idUsuario)
        {
            Conteudo = conteudo;
            IdProjeto = idProjeto;
            IdUsuario = idUsuario;
            CriadoEm = DateTime.Now;

        }
        public string Conteudo { get; private set; }

        public int IdProjeto { get; private set; }

        public int IdUsuario { get; private set; }

        public DateTime CriadoEm { get; private set; }
    }
}
