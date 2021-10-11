using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Response.Projeto
{
    public  class ProjetoResponse
    {
        public ProjetoResponse(int id ,string titulo, DateTime criadoEm)
        {
            Titulo = titulo;
            CriadoEm = criadoEm;
            Id = id;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }

        public DateTime CriadoEm  { get; set; }
    }
}
