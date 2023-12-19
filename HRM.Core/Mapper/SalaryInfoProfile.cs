using AutoMapper;
using Core.Dto.SalaryInfo;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class SalaryInfoProfile:Profile
    {
        public SalaryInfoProfile()
        {
            CreateMap<SalaryInfoEntity, SalaryInfoDto>();
            CreateMap<SalaryInfoUpdateDto, SalaryInfoEntity>();
            CreateMap<SalaryInfoCreateDto, SalaryInfoEntity>();
        }
    }
}
