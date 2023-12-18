using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.DeductibleSalary
{
    public class DeductibleSalaryCreateDto
    {
        [Key]
        public Guid DeductibleSalaryId { get; set; }
        public Guid EmployeeId { get; set; }
        public string DeductibleName { get; set; }
        public string Value { get; set; }
        public EmployeeEntity Employee { get; set; }
    }
}

