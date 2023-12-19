using AutoMapper;
using Core.Dto.Hometown;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class HometownProfile:Profile
    {
        public HometownProfile() {
            CreateMap<HometownEntity, HometownDto>();
            CreateMap<HometownUpdateDto, HometownEntity>();
            CreateMap<HometownCreateDto, HometownEntity>();
        }
    }
}
