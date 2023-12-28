using HRM.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class PermanentResidenceEntity:BaseAddressEntity
    {
        [Key]
        public Guid PermanentResidenceId { get; set; }
    }
}
