using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class EducationEntity:BaseEntity
    {
            [Key]          
            public Guid EducationId { get; set; }
            public Guid EmployeeId { get; set; }
            public int? FromYear { get; set; }
            public int? ToYear { get; set; }
            public string? EducationPlace { get; set; }
            public string? Specialized { get; set; }
            public string? Degree { get; set; }
            public string? Classification { get; set; }
            public string? GraduationYear { get; set; }
            public EmployeeEntity Employee { get; set; }
    }
}
