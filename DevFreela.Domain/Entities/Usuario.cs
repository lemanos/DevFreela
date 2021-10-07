using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario(string nome , string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Ativo = true;

            CriadoEm = DateTime.Now;
            Skills = new List<UsuarioSkill>();
            ProjetoDono = new List<Projeto>();
            ProjetoFreelancer = new List<Projeto>();

        }
        public string Nome { get; private set; }

        public string Email  { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public DateTime CriadoEm { get; private set; }

        public bool Ativo { get; set; }

        public List<UsuarioSkill> Skills { get; private set; }

        public List<Projeto> ProjetoDono { get; private set; }


        public List<Projeto> ProjetoFreelancer { get; private set; }

    }
}
