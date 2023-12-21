using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.UrgentContact
{
    public class UrgentContactCreateDto
    {
        [Key]
        public Guid UrgentContactId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Relational { get; set; }
        public string? PhoneNumber { get; set; }


    }
}
