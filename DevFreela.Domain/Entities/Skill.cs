using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
   public class Skill : BaseEntity
    {
        public Skill(string descricao)
        {
            Descricao = descricao;
            CriandoEm = DateTime.Now;
        }
        public string Descricao { get; private set; }

        public DateTime CriandoEm { get; private set; }
    }
}
