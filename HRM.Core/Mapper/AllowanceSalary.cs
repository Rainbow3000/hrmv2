
using AutoMapper;
using Core.Dto.AllowanceSalary;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class AllowanceSalary:Profile
    {
        public AllowanceSalary() {
            CreateMap<AllowanceSalaryEntity, AllowanceSalaryDto>();
            CreateMap<AllowanceSalaryUpdateDto, AllowanceSalaryEntity>();
            CreateMap<AllowanceSalaryCreateDto, AllowanceSalaryEntity>();
        }
    }
}
