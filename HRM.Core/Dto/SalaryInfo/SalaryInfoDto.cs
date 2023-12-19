using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.SalaryInfo
{
    public class SalaryInfoDto
    {
        [Key]
        public Guid SalaryInfoId { get; set; }
        public Guid EmployeeId { get; set; }
        public string LevelSalary { get; set; }
        public string LrossSalary { get; set; }
        public string NetSalary { get; set; }
        public string BasicSalary { get; set; }
        public string InsuranceSalary { get; set; }
        public string TotalSalary { get; set; }
    
    }
}
