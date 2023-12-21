using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Account
{
    public class AccountLoginDto
    {
        [Required(ErrorMessage = "Tên người dùng không được bỏ trống")]
        public string UserName  { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
        [MinLength(6,ErrorMessage = "Mật khẩu không được ít hơn 6 ký tự")]
        public string Password { get; set; }
    }
}
