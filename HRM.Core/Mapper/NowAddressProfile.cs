using AutoMapper;
using Core.Dto.NowAddress;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class NowAddressProfile:Profile
    {
        public NowAddressProfile() {
            CreateMap<NowAddressEntity, NowAddressDto>();
            CreateMap<NowAddressUpdateDto, NowAddressEntity>();
            CreateMap<NowAddressCreateDto, NowAddressEntity>();
        }
    }
}
