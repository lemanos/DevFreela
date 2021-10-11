using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Response.Projeto
{
    public class ProjetoDetalhesRespone
    {
        public ProjetoDetalhesRespone(int id, string titulo, string descricao, decimal custoTotal, DateTime? iniciadoEm, DateTime? finalizadoEm)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            CustoTotal = custoTotal;
            IniciadoEm = iniciadoEm;
            FinalizadoEm = finalizadoEm;

        }
        public int Id { get; set; }
        public string Titulo { get;  set; }

        public string Descricao { get;  set; }

        public decimal CustoTotal { get;  set; }

        public DateTime CriadoEm { get;  set; }

        public DateTime? IniciadoEm { get;  set; }

        public DateTime? FinalizadoEm { get;  set; }
    }
}
