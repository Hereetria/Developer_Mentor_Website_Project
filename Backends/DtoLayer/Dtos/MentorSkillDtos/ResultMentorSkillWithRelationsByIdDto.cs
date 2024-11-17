﻿using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SkillDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.MentorSkillDtos
{
    public class ResultMentorSkillWithRelationsByIdDto
    {
        public int MentorSkillId { get; set; }

        public int MentorId { get; set; }
        public ResultMentorDto Mentor { get; set; }

        public int SkillId { get; set; }
        public ResultSkillDto Skill { get; set; }

        public int Rate { get; set; }
    }
}
