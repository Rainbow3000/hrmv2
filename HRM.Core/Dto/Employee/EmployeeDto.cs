using Core.Dto.AllowanceSalary;
using Core.Dto.DeductibleSalary;
using Core.Dto.Education;
using Core.Dto.Experience;
using Core.Dto.File;
using Core.Dto.Hometown;
using Core.Dto.NowAddress;
using Core.Dto.PermanentResidence;
using Core.Dto.SalaryInfo;
using Core.Dto.UrgentContact;
using Core.Dto.WorkInfo;
using Core.Entity;
using Core.Enum;
using HRM.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Employee
{
    public class EmployeeDto:BaseDto
    {

        public Guid EmployeeId { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string OrganEmail { get; set; }
        public IdentifyType IdentifyType { get; set; }
        public string IdentifyNumber { get; set; }
        public string IdentifyDateRange { get; set; }
        public string IdentifyIssuedBy { get; set; }
        public string TaxtCode { get; set; }
        public string TaxtCodeDateRange { get; set; }
        public string TaxtCodeIssuedBy { get; set; }
        public string PersonalEmail { get; set; }
        public Bank Bank { get; set; }
        public string BankAccount { get; set; }

        public WorkInfoDto WorkInfoDto { get; set; }
        public List<EducationDto> EducationDtos { get; set; }
        public List<ExperienceDto> ExperienceDtos { get; set; }
        public List<FileDto> FileDtos { get; set; }
        public PermanentResidenceDto PermanentResidenceDto { get; set; }
        public NowAddressDto NowAddressDto { get; set; }
        public HometownDto HometownDto { get; set; }
        public UrgentContactDto UrgentContactDto { get; set; }
        public SalaryInfoDto SalaryInfoDto { get; set; }
        public List<AllowanceSalaryDto> AllowanceSalaryDtos { get; set; }
        public List<DeductibleSalaryDto> DeductibleSalaryDtos { get; set; }
        public int TotalSize { get; set; }
    }   
}
