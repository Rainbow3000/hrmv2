using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class FileEntity:BaseEntity
    {
            [Key]
            public Guid FileId { get; set; }
            public Guid EmployeeId { get; set; }
            public string? FileName { get; set; }
            public string? UploadDate { get; set; }
            public string? FileUrl { get; set; }
            public EmployeeEntity Employee { get; set; }
    }
}
