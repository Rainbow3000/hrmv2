using AutoMapper;
using Core.Dto.AllowanceSalary;
using Core.Dto.DeductibleSalary;
using Core.Dto.Education;
using Core.Dto.Employee;
using Core.Dto.Experience;
using Core.Dto.File;
using Core.Dto.Hometown;
using Core.Dto.NowAddress;
using Core.Dto.PermanentResidence;
using Core.Dto.SalaryInfo;
using Core.Dto.UrgentContact;
using Core.Dto.WorkInfo;
using Core.Entity;
using Core.Exceptions;
using Core.Interface.Repository;
using HRM.Core.Dto.Filter;
using HRM.Core.Helper;
using HRM.Core.Interface.Repository;
using HRM.Core.Interface.Service;
using HRM.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Service
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository  _employeeRepository;
        private readonly IAccountRepository _accountRepository; 
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IAccountRepository accountRepository, IMapper mapper) {
            _employeeRepository = employeeRepository;
            _accountRepository = accountRepository; 
            _mapper = mapper;
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var employeeEntity = await _employeeRepository.GetAsync(id);
            if (employeeEntity == null)
            {
                throw new NotFoundException("Nhân viên không tồn tại");
            }

            return await _employeeRepository.DeleteAsync(id); 
        }

        public async Task<List<EmployeeDto>> GetAllAsync(FilterDto filter)
        {

            List<EmployeeDto> employeeDtos = new List<EmployeeDto>();
            var employeeEntities = await _employeeRepository.GetAllAsync(filter);

            if(employeeEntities.Count > 0)
            {
                employeeEntities.ForEach(item =>
                {
                    EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(item); 
                    if (item.WorkInfo != null)
                    {
                        employeeDto.WorkInfoDto = _mapper.Map<WorkInfoDto>(item.WorkInfo);
                    }
                    if(item.Education.Count > 0)
                    {
                        employeeDto.EducationDtos = new List<EducationDto>();
                        item.Education.ForEach(edu =>
                        {
                            employeeDto.EducationDtos.Add(_mapper.Map<EducationDto>(edu));   
                        }); 
                    }


                    if (item.Experience.Count > 0)
                    {
                        employeeDto.ExperienceDtos = new List<ExperienceDto>();
                        item.Experience.ForEach(exp =>
                        {
                            employeeDto.ExperienceDtos.Add(_mapper.Map<ExperienceDto>(exp));
                        });
                    }

                    if (item.File.Count > 0)
                    {
                        employeeDto.FileDtos = new List<FileDto>();
                        item.File.ForEach(f =>
                        {
                            employeeDto.FileDtos.Add(_mapper.Map<FileDto>(f));
                        });
                    }

                    if (item.PermanentResidence != null)
                    {
                        employeeDto.PermanentResidenceDto = _mapper.Map<PermanentResidenceDto>(item.PermanentResidence);
                    }

                    if (item.NowAddress != null)
                    {
                        employeeDto.NowAddressDto = _mapper.Map<NowAddressDto>(item.NowAddress);
                    }

                    if (item.Hometown != null)
                    {
                        employeeDto.HometownDto = _mapper.Map<HometownDto>(item.Hometown);
                    }

                    if (item.UrgentContact != null)
                    {
                        employeeDto.UrgentContactDto = _mapper.Map<UrgentContactDto>(item.UrgentContact);
                    }

                    if (item.SalaryInfo != null)
                    {
                        employeeDto.SalaryInfoDto = _mapper.Map<SalaryInfoDto>(item.SalaryInfo);
                    }

                    if (item.AllowanceSalary.Count > 0)
                    {
                        employeeDto.AllowanceSalaryDtos = new List<AllowanceSalaryDto>();
                        item.AllowanceSalary.ForEach(als =>
                        {
                            employeeDto.AllowanceSalaryDtos.Add(_mapper.Map<AllowanceSalaryDto>(als));
                        });
                    }

                    if (item.DeductibleSalary.Count > 0)
                    {
                        employeeDto.DeductibleSalaryDtos = new List<DeductibleSalaryDto>();
                        item.DeductibleSalary.ForEach(dts =>
                        {
                            employeeDto.DeductibleSalaryDtos.Add(_mapper.Map<DeductibleSalaryDto>(dts));
                        });
                    }

                    employeeDtos.Add(employeeDto);
                });
            }

            return employeeDtos;
        }

        public async Task<EmployeeDto> GetAsync(Guid id)
        {
            var employeeEntity =  await _employeeRepository.GetAsync(id); 
            if(employeeEntity == null)
            {
                throw new NotFoundException("Nhân viên không tồn tại");
            }

            var employeeDto = _mapper.Map<EmployeeDto>(employeeEntity); 

            if (employeeEntity.WorkInfo != null)
            {
                employeeDto.WorkInfoDto = _mapper.Map<WorkInfoDto>(employeeEntity.WorkInfo);
            }
            if (employeeEntity.Education.Count > 0)
            {
                employeeDto.EducationDtos = new List<EducationDto>();
                employeeEntity.Education.ForEach(edu =>
                {
                    employeeDto.EducationDtos.Add(_mapper.Map<EducationDto>(edu));
                });
            }


            if (employeeEntity.Experience.Count > 0)
            {
                employeeDto.ExperienceDtos = new List<ExperienceDto>();
                employeeEntity.Experience.ForEach(exp =>
                {
                    employeeDto.ExperienceDtos.Add(_mapper.Map<ExperienceDto>(exp));
                });
            }

            if (employeeEntity.File.Count > 0)
            {
                employeeDto.FileDtos = new List<FileDto>();
                employeeEntity.File.ForEach(f =>
                {
                    employeeDto.FileDtos.Add(_mapper.Map<FileDto>(f));
                });
            }

            if (employeeEntity.PermanentResidence != null)
            {
                employeeDto.PermanentResidenceDto = _mapper.Map<PermanentResidenceDto>(employeeEntity.PermanentResidence);
            }

            if (employeeEntity.NowAddress != null)
            {
                employeeDto.NowAddressDto = _mapper.Map<NowAddressDto>(employeeEntity.NowAddress);
            }

            if (employeeEntity.Hometown != null)
            {
                employeeDto.HometownDto = _mapper.Map<HometownDto>(employeeEntity.Hometown);
            }

            if (employeeEntity.UrgentContact != null)
            {
                employeeDto.UrgentContactDto = _mapper.Map<UrgentContactDto>(employeeEntity.UrgentContact);
            }

            if (employeeEntity.SalaryInfo != null)
            {
                employeeDto.SalaryInfoDto = _mapper.Map<SalaryInfoDto>(employeeEntity.SalaryInfo);
            }

            if (employeeEntity.AllowanceSalary.Count > 0)
            {
                employeeDto.AllowanceSalaryDtos = new List<AllowanceSalaryDto>();
                employeeEntity.AllowanceSalary.ForEach(als =>
                {
                    employeeDto.AllowanceSalaryDtos.Add(_mapper.Map<AllowanceSalaryDto>(als));
                });
            }

            if (employeeEntity.DeductibleSalary.Count > 0)
            {
                employeeDto.DeductibleSalaryDtos = new List<DeductibleSalaryDto>();
                employeeEntity.DeductibleSalary.ForEach(dts =>
                {
                    employeeDto.DeductibleSalaryDtos.Add(_mapper.Map<DeductibleSalaryDto>(dts));
                });
            }

            return employeeDto; 
             
        }

        public async Task<EmployeeDto> InsertAsync(EmployeeCreateDto employeeCreateDto)
        {
            // Map từ EntityCreateDto thành Entity

            var employeeExisted = await _employeeRepository.getByCode(employeeCreateDto.Code);

            if (employeeExisted != null) {
                throw new DuplicateException("Mã nhân viên đã tồn tại");
            }

            var workInfoEntity = _mapper.Map<WorkInfoEntity>(employeeCreateDto.WorkInfoDto);
            List<EducationEntity> educationEntities = _mapper.Map<List<EducationEntity>>(employeeCreateDto.EducationDtos);
            List<ExperienceEntity> experienceEntities = _mapper.Map<List<ExperienceEntity>>(employeeCreateDto.ExperienceDtos);
            List<FileEntity> fileEntities = _mapper.Map<List<FileEntity>>(employeeCreateDto.FileDtos);
            var permanentResidenceEntity = _mapper.Map<PermanentResidenceEntity>(employeeCreateDto.PermanentResidenceDto);
            var nowAddressEntity = _mapper.Map<NowAddressEntity>(employeeCreateDto.NowAddressDto);
            var hometownEntity = _mapper.Map<HometownEntity>(employeeCreateDto.HometownDto);
            var urgentContactEntity = _mapper.Map<UrgentContactEntity>(employeeCreateDto.UrgentContactDto); 
            var salaryInfoEntity = _mapper.Map<SalaryInfoEntity>(employeeCreateDto.SalaryInfoDto);
            List<AllowanceSalaryEntity> allowanceSalaryEntities = _mapper.Map<List<AllowanceSalaryEntity>>(employeeCreateDto.AllowanceSalaryDtos);
            List<DeductibleSalaryEntity> deductibleSalaryEntities = _mapper.Map<List<DeductibleSalaryEntity>>(employeeCreateDto.DeductibleSalaryDtos);

            // Thêm Guid cho các entity
            workInfoEntity.WorkInfoId = Guid.NewGuid();
            permanentResidenceEntity.PermanentResidenceId = Guid.NewGuid(); 
            nowAddressEntity.NowAddressId = Guid.NewGuid();
            hometownEntity.HometownId = Guid.NewGuid();
            urgentContactEntity.UrgentContactId = Guid.NewGuid();
            salaryInfoEntity.SalaryInfoId = Guid.NewGuid();
            if(educationEntities.Count > 0)
            {
                educationEntities.ForEach(item =>
                {
                    item.EducationId = Guid.NewGuid();
                });
            }
            if (experienceEntities.Count > 0)
            {
                experienceEntities.ForEach(item =>
                {
                    item.ExperienceId = Guid.NewGuid();
                });
            }

            if (fileEntities.Count > 0)
            {
                fileEntities.ForEach(item =>
                {
                    item.FileId = Guid.NewGuid();
                });
            }
            if (allowanceSalaryEntities.Count > 0)
            {
                allowanceSalaryEntities.ForEach(item =>
                {
                    item.AllowanceSalaryId = Guid.NewGuid();
                });
            }
            if (deductibleSalaryEntities.Count > 0)
            {
                deductibleSalaryEntities.ForEach(item =>
                {
                    item.DeductibleSalaryId = Guid.NewGuid();
                });
            }

            // Add các entity vào các trường tương ứng của Employee
            var employeeEntity = _mapper.Map<EmployeeEntity>(employeeCreateDto);
            employeeEntity.EmployeeId = Guid.NewGuid(); 
            employeeEntity.WorkInfo = workInfoEntity;
            employeeEntity.Education = educationEntities;
            employeeEntity.Experience = experienceEntities;
            employeeEntity.File = fileEntities;
            employeeEntity.PermanentResidence = permanentResidenceEntity;
            employeeEntity.NowAddress = nowAddressEntity; 
            employeeEntity.Hometown = hometownEntity;
            employeeEntity.UrgentContact = urgentContactEntity;
            employeeEntity.SalaryInfo = salaryInfoEntity;
            employeeEntity.AllowanceSalary = allowanceSalaryEntities;
            employeeEntity.DeductibleSalary= deductibleSalaryEntities;

            // Ghi dữ liệu vào database
            int rowEffected = await _employeeRepository.InsertAsync(employeeEntity);
            if(rowEffected > 0) {

                // Map từ Entity về EntityDto
                var workInfoDto = _mapper.Map<WorkInfoDto>(workInfoEntity);
                List<EducationDto> educationDtos = _mapper.Map<List<EducationDto>>(educationEntities);
                List<ExperienceDto> experienceDtos = _mapper.Map<List<ExperienceDto>>(experienceEntities);
                List<FileDto> fileDtos  = _mapper.Map<List<FileDto>>(fileEntities);
                var permanentResidenceDto = _mapper.Map<PermanentResidenceDto>(permanentResidenceEntity);
                var nowAddressDto = _mapper.Map<NowAddressDto>(nowAddressEntity);
                var hometownDto = _mapper.Map<HometownDto>(hometownEntity);
                var urgentContactDto = _mapper.Map<UrgentContactDto>(urgentContactEntity);
                var salaryInfoDto = _mapper.Map<SalaryInfoDto>(salaryInfoEntity);
                List<AllowanceSalaryDto> allowanceSalaryDtos = _mapper.Map<List<AllowanceSalaryDto>>(allowanceSalaryEntities);
                List<DeductibleSalaryDto> deductibleSalaryDtos = _mapper.Map<List<DeductibleSalaryDto>>(deductibleSalaryEntities);

                // Add các entityDto vào các trường của employeeDto tương ứng
                var employeeDto =  _mapper.Map<EmployeeDto>(employeeEntity);
                employeeDto.WorkInfoDto = workInfoDto;
                employeeDto.EducationDtos = educationDtos;
                employeeDto.ExperienceDtos = experienceDtos; 
                employeeDto.FileDtos =  fileDtos;
                employeeDto.PermanentResidenceDto = permanentResidenceDto;
                employeeDto.NowAddressDto = nowAddressDto;
                employeeDto.HometownDto = hometownDto; 
                employeeDto.UrgentContactDto = urgentContactDto;
                employeeDto.SalaryInfoDto = salaryInfoDto;
                employeeDto.AllowanceSalaryDtos = allowanceSalaryDtos;
                employeeDto.DeductibleSalaryDtos = deductibleSalaryDtos;

                return employeeDto; 
            }

            throw new Exception("Có lỗi xảy ra");

        }

        public async Task<EmployeeDto> UpdateAsync(EmployeeUpdateDto employeeUpdateDto, Guid id)
        {
            var employeeExisted = await _employeeRepository.GetAsync(id); 
            if(employeeExisted == null)
            {
                throw new NotFoundException("Nhân viên không tồn tại");
            }
            


            if(employeeExisted.Code != employeeUpdateDto.Code)
            {
                var findEmployeeByCode = await _employeeRepository.getByCode(employeeUpdateDto.Code);
                if(findEmployeeByCode != null)
                {
                    throw new DuplicateException("Mã nhân viên đã tồn tại");
                }
            }

            // Map từ EntityUpdateDto thành Entity
            var workInfoEntity = _mapper.Map<WorkInfoEntity>(employeeUpdateDto.WorkInfoDto);
            List<EducationEntity> educationEntities = _mapper.Map<List<EducationEntity>>(employeeUpdateDto.EducationDtos);
            List<ExperienceEntity> experienceEntities = _mapper.Map<List<ExperienceEntity>>(employeeUpdateDto.ExperienceDtos);
            List<FileEntity> fileEntities = _mapper.Map<List<FileEntity>>(employeeUpdateDto.FileDtos);
            var permanentResidenceEntity = _mapper.Map<PermanentResidenceEntity>(employeeUpdateDto.PermanentResidenceDto);
            var nowAddressEntity = _mapper.Map<NowAddressEntity>(employeeUpdateDto.NowAddressDto);
            var hometownEntity = _mapper.Map<HometownEntity>(employeeUpdateDto.HometownDto);
            var urgentContactEntity = _mapper.Map<UrgentContactEntity>(employeeUpdateDto.UrgentContactDto);
            var salaryInfoEntity = _mapper.Map<SalaryInfoEntity>(employeeUpdateDto.SalaryInfoDto);
            List<AllowanceSalaryEntity> allowanceSalaryEntities = _mapper.Map<List<AllowanceSalaryEntity>>(employeeUpdateDto.AllowanceSalaryDtos);
            List<DeductibleSalaryEntity> deductibleSalaryEntities = _mapper.Map<List<DeductibleSalaryEntity>>(employeeUpdateDto.DeductibleSalaryDtos);

           

            // Add các entity vào các trường tương ứng của Employee
            var employeeEntity = _mapper.Map<EmployeeEntity>(employeeUpdateDto);
            employeeEntity.EmployeeId = id; 
            employeeEntity.WorkInfo = workInfoEntity;
            employeeEntity.Education = educationEntities;
            employeeEntity.Experience = experienceEntities;
            employeeEntity.File = fileEntities;
            employeeEntity.PermanentResidence = permanentResidenceEntity;
            employeeEntity.NowAddress = nowAddressEntity;
            employeeEntity.Hometown = hometownEntity;
            employeeEntity.UrgentContact = urgentContactEntity;
            employeeEntity.SalaryInfo = salaryInfoEntity;
            employeeEntity.AllowanceSalary = allowanceSalaryEntities;
            employeeEntity.DeductibleSalary = deductibleSalaryEntities;

            // Cập nhật dữ liệu vào database
            await _employeeRepository.UpdateAsync(employeeEntity,id);

            // Map từ Entity về EntityDto
            var workInfoDto = _mapper.Map<WorkInfoDto>(workInfoEntity);
            List<EducationDto> educationDtos = _mapper.Map<List<EducationDto>>(educationEntities);
            List<ExperienceDto> experienceDtos = _mapper.Map<List<ExperienceDto>>(experienceEntities);
            List<FileDto> fileDtos = _mapper.Map<List<FileDto>>(fileEntities);
            var permanentResidenceDto = _mapper.Map<PermanentResidenceDto>(permanentResidenceEntity);
            var nowAddressDto = _mapper.Map<NowAddressDto>(nowAddressEntity);
            var hometownDto = _mapper.Map<HometownDto>(hometownEntity);
            var urgentContactDto = _mapper.Map<UrgentContactDto>(urgentContactEntity);
            var salaryInfoDto = _mapper.Map<SalaryInfoDto>(salaryInfoEntity);
            List<AllowanceSalaryDto> allowanceSalaryDtos = _mapper.Map<List<AllowanceSalaryDto>>(allowanceSalaryEntities);
            List<DeductibleSalaryDto> deductibleSalaryDtos = _mapper.Map<List<DeductibleSalaryDto>>(deductibleSalaryEntities);

            // Add các entityDto vào các trường của employeeDto tương ứng
            var employeeDto = _mapper.Map<EmployeeDto>(employeeEntity);
            employeeDto.WorkInfoDto = workInfoDto;
            employeeDto.EducationDtos = educationDtos;
            employeeDto.ExperienceDtos = experienceDtos;
            employeeDto.FileDtos = fileDtos;
            employeeDto.PermanentResidenceDto = permanentResidenceDto;
            employeeDto.NowAddressDto = nowAddressDto;
            employeeDto.HometownDto = hometownDto;
            employeeDto.UrgentContactDto = urgentContactDto;
            employeeDto.SalaryInfoDto = salaryInfoDto;
            employeeDto.AllowanceSalaryDtos = allowanceSalaryDtos;
            employeeDto.DeductibleSalaryDtos = deductibleSalaryDtos;

            return employeeDto;
        }
    }
}
