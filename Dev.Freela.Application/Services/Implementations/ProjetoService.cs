using Dev.Freela.Application.Request;
using Dev.Freela.Application.Request.Comentario;
using Dev.Freela.Application.Request.Projeto;
using Dev.Freela.Application.Response;
using Dev.Freela.Application.Response.Projeto;
using Dev.Freela.Application.Services.Interfaces;
using DevFreela.Domain.Entities;
using DevFreela.Infrastructure.Persistense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Services.Implementations
{
    public class ProjetoService : IProjetoService
    {
        private readonly DbContext _dbContext;

        public ProjetoService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AdicionarComentario(CriarComentarioRequest comentarioRequest)
        {
            var comentario = new ProjetoComentario(comentarioRequest.Conteudo, comentarioRequest.IdUsuario, comentarioRequest.IdProjeto);

            _dbContext.Comentarios.Add(comentario);
        }

        public void Atualizar(AtualizarProjetoRequest projetoResponse)
        {
            var projeto = _dbContext.Projetos.SingleOrDefault(p => p.Id == projetoResponse.Id);

            projeto.Atualizar(projetoResponse.Titulo, projetoResponse.Descricao, projetoResponse.CustoTotal);
        }

        public int Criar(CriarProjetoRequest projetoRequest)
        {
            var projeto = new Projeto(projetoRequest.Titulo, projetoRequest.Descricao, projetoRequest.IdCliente, projetoRequest.IdFreelancer, projetoRequest.CustoTotal);

            _dbContext.Projetos.Add(projeto);

            return projeto.Id;
        }

        public void Deletar(int id)
        {
            var projeto = _dbContext.Projetos.SingleOrDefault(p => p.Id == id);

            projeto.Cancelar();
        }

        public void Finalizar(int id)
        {
            var projeto = _dbContext.Projetos.SingleOrDefault(p => p.Id == id);

            projeto.Finalizar();

        }

        public void Iniciar(int id)
        {
            var projeto = _dbContext.Projetos.SingleOrDefault(p => p.Id == id);

            projeto.Iniciar();
        }

        public ProjetoDetalhesRespone ListarPorId(int id)
        {
            var projetos = _dbContext.Projetos.SingleOrDefault(p => p.Id == id);

            var projetosDetalhes = new ProjetoDetalhesRespone(
                projetos.Id,
                projetos.Titulo,
                projetos.Descricao,
                projetos.TotalCusto,
                projetos.IniciadoEm,
                projetos.FinalizadoEm

                );

            return projetosDetalhes;
        }

        public List<ProjetoResponse> ListarTodos(string query)
        {
            var projetos = _dbContext.Projetos;

            var projetosResponse = projetos
                .Select(p => new ProjetoResponse(p.Id, p.Titulo, p.CriadoEm))
                .ToList();

            return projetosResponse;


        }
    }
}
