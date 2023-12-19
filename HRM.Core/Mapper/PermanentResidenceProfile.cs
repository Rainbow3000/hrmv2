using AutoMapper;
using Core.Dto.PermanentResidence;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class PermanentResidenceProfile:Profile
    {
        public PermanentResidenceProfile() {
            CreateMap<PermanentResidenceEntity, PermanentResidenceDto>();
            CreateMap<PermanentResidenceUpdateDto, PermanentResidenceEntity>();
            CreateMap<PermanentResidenceCreateDto, PermanentResidenceEntity>();
        }
    }
}
