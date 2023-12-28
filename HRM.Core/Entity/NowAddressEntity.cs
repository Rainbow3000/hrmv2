using HRM.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class NowAddressEntity:BaseAddressEntity
    {
        [Key]
        public Guid NowAddressId { get; set; }
      
    }
}
