using AutoMapper;
using Core.Dto.WorkInfo;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class WorkInfoProfile:Profile
    {
        public WorkInfoProfile() {
            CreateMap<WorkInfoEntity, WorkInfoDto>();
            CreateMap<WorkInfoUpdateDto, WorkInfoEntity>();
            CreateMap<WorkInfoCreateDto, WorkInfoEntity>();
        }
    }
}
