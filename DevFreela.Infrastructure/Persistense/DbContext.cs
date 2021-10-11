using DevFreela.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistense
{
   public  class DbContext
    {
        public DbContext()
        {
            Projetos = new List<Projeto>
            {
                new Projeto ("Meu projeto ASPNET Core 1","Minha descricao de projeto 1",1,1,10000),
                new Projeto ("Meu projeto ASPNET Core 2","Minha descricao de projeto 2",1,1,20000),
                new Projeto ("Meu projeto ASPNET Core 3","Minha descricao de projeto 3",1,1,30000)

            };

            Usuarios = new List<Usuario>
            {
                new Usuario ("Lêmanos Fernandes","lemanossouza@gmai.com", new DateTime(1993,8,30)),
                new Usuario ("Antonella Fernandes","lemanossozua@gmail.com",new DateTime(2020,2,15)),
                new Usuario ("Alda Fernandes","lemanossouzagmal.com",new DateTime(1996,12,11))

            };

            Skills = new List<Skill>
            {
                new Skill (".NET Core"),
                new Skill ("C#"),
                new Skill ("SQL")

            };

        }
        public List<Projeto> Projetos { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public List<Skill> Skills { get; set; }

        public List<ProjetoComentario> Comentarios { get; set; }




    }
}
