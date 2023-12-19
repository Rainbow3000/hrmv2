using AutoMapper;
using Core.Dto.Employee;
using Core.Entity;

namespace HRM.Core.Mapper
{
    public class EmployeeProfile:Profile
    {
           public EmployeeProfile()
        {
            CreateMap<EmployeeEntity, EmployeeDto>();
            CreateMap<EmployeeUpdateDto, EmployeeEntity>();
            CreateMap<EmployeeCreateDto, EmployeeEntity>();
        }
    }
}
