using Dev.Freela.Application.Request;
using Dev.Freela.Application.Request.Comentario;
using Dev.Freela.Application.Request.Projeto;
using Dev.Freela.Application.Response;
using Dev.Freela.Application.Response.Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Services.Interfaces
{
    public interface IProjetoService
    {
        List<ProjetoResponse> ListarTodos(string query);

        ProjetoDetalhesRespone ListarPorId(int id);

        void AdicionarComentario(CriarComentarioRequest comentarioRequest);

        int Criar(CriarProjetoRequest projetoRequest);

        void Atualizar(AtualizarProjetoRequest projetoResponse);

        void Deletar(int id);

        void Iniciar(int id);

        void Finalizar(int id);

    }
}
