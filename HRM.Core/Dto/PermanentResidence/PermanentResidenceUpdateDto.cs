using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.PermanentResidence
{
    public class PermanentResidenceUpdateDto
    {
        [Key]
        public Guid PermanentResidenceId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Wards { get; set; }
        public string? HouseNumber { get; set; }

    }
}
