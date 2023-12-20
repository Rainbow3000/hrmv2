using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class ExperienceEntity:BaseEntity
    {
            [Key]
            public Guid ExperienceId { get; set; }
            public Guid EmployeeId { get; set; }
            public string? FromDay { get; set; }
            public string? ToDay { get; set; }
            public string? WorkPlace { get; set; }
            public string? WorkPosition { get; set; }
            public string? ComparePerson { get; set; }
            public bool? IsCheckedCompare { get; set; }
            public string? Note { get; set; }
            public EmployeeEntity Employee { get; set; }

    }
}
