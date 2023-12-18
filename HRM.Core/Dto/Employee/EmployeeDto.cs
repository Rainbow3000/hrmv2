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

        [Required(ErrorMessage = "Mã nhân viên không được bỏ trống")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Tên nhân viên không được bỏ trống")]
        public string Fullname { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }

        [Required(ErrorMessage = "Số điện thoại nhân viên không được bỏ trống")]
        public string PhoneNumber { get; set; }
        public string OrganEmail { get; set; }
        public string IdentifyType { get; set; }
        public string IdentifyNumber { get; set; }
        public string IdentifyDateRange { get; set; }
        public string IdentifyIssuedBy { get; set; }
        public string TaxtCode { get; set; }
        public string TaxtCodeDateRange { get; set; }
        public string TaxtCodeIssuedBy { get; set; }
        public string PersonalEmail { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }

        public List<WorkInfoDto> WorkInfoDtos { get; set; }
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

    }
}
