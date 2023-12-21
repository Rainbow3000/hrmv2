using Core.Enum;
using HRM.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class EmployeeEntity:BaseEntity
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string Code { get; set; }
        public string Fullname { get; set; }
        public DateTime? Dob { get; set; }
        public Gender? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string? OrganEmail { get; set; }
        public IdentifyType? IdentifyType { get; set; }
        public string? IdentifyNumber { get; set; }
        public string? IdentifyDateRange { get; set; }
        public string? IdentifyIssuedBy { get; set; }
        public string? TaxtCode { get; set; }
        public string? TaxtCodeDateRange { get; set; }
        public string? TaxtCodeIssuedBy { get; set; }
        public string? PersonalEmail { get; set; }
        public Bank? Bank { get; set; }
        public string? BankAccount { get; set; }

        public WorkInfoEntity WorkInfo { get; set; }
        public List<EducationEntity> Education { get; set; }
        public List<ExperienceEntity> Experience { get; set; }
        public List<FileEntity>? File { get; set;}
        public PermanentResidenceEntity PermanentResidence { get; set; }
        public NowAddressEntity NowAddress { get; set; }
        public HometownEntity Hometown { get; set; }
        public UrgentContactEntity UrgentContact { get; set; }
        public SalaryInfoEntity SalaryInfo { get; set; }
        public List<AllowanceSalaryEntity> AllowanceSalary { get; set; }
        public List<DeductibleSalaryEntity> DeductibleSalary { get; set; }
        public AccountEntity Account { get; set; }
    }
}
