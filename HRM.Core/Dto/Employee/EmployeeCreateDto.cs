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
    public class EmployeeCreateDto
    {

        [Required(ErrorMessage = "Mã nhân viên không được bỏ trống")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Tên nhân viên không được bỏ trống")]
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public Gender? Gender { get; set; }

        [Required(ErrorMessage = "Số điện thoại nhân viên không được bỏ trống")]
        public string PhoneNumber { get; set; }

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

        public WorkInfoCreateDto?  WorkInfoDto { get; set; }
        public List<EducationCreateDto>? EducationDtos { get; set; }
        public List<ExperienceCreateDto>? ExperienceDtos { get; set; }
        public List<FileCreateDto>? FileDtos { get; set; }
        public PermanentResidenceCreateDto? PermanentResidenceDto { get; set; }
        public NowAddressCreateDto? NowAddressDto { get; set; }
        public HometownCreateDto? HometownDto { get; set; }
        public UrgentContactCreateDto? UrgentContactDto { get; set; }
        public SalaryInfoCreateDto? SalaryInfoDto { get; set; }
        public List<AllowanceSalaryCreateDto>? AllowanceSalaryDtos { get; set; }
        public List<DeductibleSalaryCreateDto>? DeductibleSalaryDtos { get; set; }
    }
}
