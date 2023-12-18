
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Account
{
    public class AccountUpdateDto:BaseDto
    {
        public Guid AccountId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Status { get; set; }
    }
}
