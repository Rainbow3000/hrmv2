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
    public class EmployeeUpdateDto
    {

        [Required(ErrorMessage = "Mã nhân viên không được bỏ trống")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Tên nhân viên không được bỏ trống")]
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public Gender? Gender { get; set; }

        [Required(ErrorMessage = "Số điện thoại nhân viên không được bỏ trống")]
        public string? PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Emai không đúng định dạng.")]
        public string? OrganEmail { get; set; }
        public IdentifyType? IdentifyType { get; set; }
        public string? IdentifyNumber { get; set; }
        public string? IdentifyDateRange { get; set; }
        public string? IdentifyIssuedBy { get; set; }
        public string? TaxtCode { get; set; }
        public string? TaxtCodeDateRange { get; set; }
        public string? TaxtCodeIssuedBy { get; set; }

        [EmailAddress(ErrorMessage = "Emai không đúng định dạng.")]
        public string? PersonalEmail { get; set; }
        public Bank? Bank { get; set; }
        public string? BankAccount { get; set; }

        public WorkInfoUpdateDto WorkInfoDto { get; set; }
        public List<EducationUpdateDto> EducationDtos { get; set; }
        public List<ExperienceUpdateDto> ExperienceDtos { get; set; }
        public List<FileUpdateDto>? FileDtos { get; set; }
        public PermanentResidenceUpdateDto PermanentResidenceDto { get; set; }
        public NowAddressUpdateDto NowAddressDto { get; set; }
        public HometownUpdateDto HometownDto { get; set; }
        public UrgentContactUpdateDto UrgentContactDto { get; set; }
        public SalaryInfoUpdateDto SalaryInfoDto { get; set; }
        public List<AllowanceSalaryUpdateDto> AllowanceSalaryDtos { get; set; }
        public List<DeductibleSalaryUpdateDto> DeductibleSalaryDtos { get; set; }
    }
}
