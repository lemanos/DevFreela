﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Application.Response.Skill
{
   public  class SkillResponse
    {
        public SkillResponse(int id , string descricao)
        {
            Id = id;
            Descricao = descricao;
            
        }
        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}
