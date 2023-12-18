﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Account
{
    public class AccountDto : BaseDto
    {
        public Guid AccountId { get; set; }
        public string Email { get; set; }
        public string? Role { get; set; }
        public int Status { get; set; }
    }
}
