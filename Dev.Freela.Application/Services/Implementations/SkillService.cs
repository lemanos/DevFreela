using Dev.Freela.Application.Response.Skill;
using Dev.Freela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DbContext _dbContext;

        public SkillService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SkillResponse> ListarTodos()
        {
            var skills = _dbContext.Skills;

            var skillsResponse = skills
                .Select(S => new SkillResponse(S.Id, S.Descricao))
                .ToList();

            return skillsResponse;
        }
    }
}
