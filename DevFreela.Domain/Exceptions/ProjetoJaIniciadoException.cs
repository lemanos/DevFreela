using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Exceptions
{
   public  class ProjetoJaIniciadoException : Exception
    {
        public ProjetoJaIniciadoException() : base("Proje is already in started status")
        {

        }
    }
}
