using DevFreela.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
    public  class Projeto : BaseEntity
    {

        public Projeto(string titulo, string descricao, int idCliente, int idFreelancer, decimal totalCusto)
        {
            Titulo = titulo;
            Descricao = descricao;
            IdCliente = idCliente;
            IdFreelancer = idFreelancer;
            TotalCusto = totalCusto;

            CriadoEm = DateTime.Now;
            Status = ProjetoStatusEnum.Criado;
            Comentarios = new List<ProjetoComentario>();
        }
        public string Titulo { get; private set; }

        public string Descricao { get; private set; }

        public int IdCliente { get; set; }

        public int IdFreelancer { get; set; }

        public decimal TotalCusto { get; private set; }

        public DateTime CriadoEm { get; private set; }

        public DateTime? IniciadoEm  { get; private set; }

        public DateTime? FinalizadoEm { get; private set; }

        public ProjetoStatusEnum Status { get; private set; }

        public List<ProjetoComentario> Comentarios { get; private set; }
    }
}
