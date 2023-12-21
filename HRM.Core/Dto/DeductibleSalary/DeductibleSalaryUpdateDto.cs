using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.DeductibleSalary
{
    public class DeductibleSalaryUpdateDto
    {
        [Key]
        public Guid DeductibleSalaryId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? DeductibleName { get; set; }
        public double? Value { get; set; }

    }
}

