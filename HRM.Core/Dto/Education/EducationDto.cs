using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Education
{
    public class EducationDto
    {
        [Key]
        public Guid EducationId { get; set; }
        public Guid EmployeeId { get; set; }
        public string FromYear { get; set; }
        public string ToYear { get; set; }
        public string EducationPlace { get; set; }
        public string Specification { get; set; }
        public string Degree { get; set; }
        public string Classification { get; set; }
        public string GraduationYear { get; set; }

    }
}
