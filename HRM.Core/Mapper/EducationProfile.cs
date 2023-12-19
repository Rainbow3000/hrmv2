using AutoMapper;
using Core.Dto.Education;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class EducationProfile:Profile
    {
        public EducationProfile() {
            CreateMap<EducationEntity, EducationDto>();
            CreateMap<EducationUpdateDto, EducationEntity>();
            CreateMap<EducationCreateDto, EducationEntity>();
        }
    }
}
