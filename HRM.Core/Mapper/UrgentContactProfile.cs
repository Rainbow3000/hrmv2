using AutoMapper;
using Core.Dto.UrgentContact;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class UrgentContactProfile:Profile
    {
        public UrgentContactProfile() {
            CreateMap<UrgentContactEntity, UrgentContactDto>();
            CreateMap<UrgentContactUpdateDto, UrgentContactEntity>();
            CreateMap<UrgentContactCreateDto, UrgentContactEntity>();
        }
    }
}
