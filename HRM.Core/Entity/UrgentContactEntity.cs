using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class UrgentContactEntity:BaseEntity
    {
        [Key]
        public Guid UrgentContactId { get; set; }
        public Guid EmployeeId { get; set; }
        public string Fullname { get; set; }
        public string Relational { get; set; }
        public string PhoneNumber { get; set; }
        public EmployeeEntity Employee { get; set; }

    }
}
