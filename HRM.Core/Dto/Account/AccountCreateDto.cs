using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Account
{
    public class AccountCreateDto
    {
        [Key]
        public Guid AccountId { get; set; }
        public Guid EmployeeId { get; set; }

        [Required(ErrorMessage = "Tên tài khoản không được để trống")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Status { get; set; }
    }
}
