﻿using Dev.Freela.Application.Response.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillResponse> ListarTodos();
    }
}
