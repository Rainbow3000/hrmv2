using AutoMapper;
using Core.Dto.File;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Mapper
{
    public class FileProfile:Profile
    {
        public FileProfile() {
            CreateMap<FileEntity, FileDto>();
            CreateMap<FileUpdateDto, FileEntity>();
            CreateMap<FileCreateDto, FileEntity>();
        }
    }
}
