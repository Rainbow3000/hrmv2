using AutoMapper;
using Core.Dto.Experience;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class ExperienceProfile:Profile
    {
        public ExperienceProfile()
        {
            CreateMap<ExperienceEntity, ExperienceDto>();
            CreateMap<ExperienceUpdateDto, ExperienceEntity>();
            CreateMap<ExperienceCreateDto, ExperienceEntity>();
        }
    }
}
