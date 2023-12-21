using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.SalaryInfo
{
    public class SalaryInfoUpdateDto
    {
        [Key]
        public Guid SalaryInfoId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? LevelSalary { get; set; }
        public double? grossSalary { get; set; }
        public double? NetSalary { get; set; }
        public double? BasicSalary { get; set; }
        public double? InsuranceSalary { get; set; }
        public double? TotalSalary { get; set; }

    }
}
