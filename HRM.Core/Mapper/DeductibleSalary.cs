using AutoMapper;
using Core.Dto.DeductibleSalary;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class DeductibleSalary:Profile
    {
        public DeductibleSalary()
        {
            CreateMap<DeductibleSalaryEntity, DeductibleSalaryDto>();
            CreateMap<DeductibleSalaryUpdateDto, DeductibleSalaryEntity>();
            CreateMap<DeductibleSalaryCreateDto, DeductibleSalaryEntity>();
        }
    }
}
