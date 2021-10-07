using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
    public class UsuarioSkill : BaseEntity
    {
        public UsuarioSkill(int idUsuario , int idSkill)
        {
            IdUsuario = idUsuario;
            IdSkill = idSkill;
        }
        public int IdUsuario { get; private set; }

        public int IdSkill { get; private set; }
    }
}
