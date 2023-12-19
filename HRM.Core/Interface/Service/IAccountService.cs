using Core.Dto.Account;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface.Service
{
    public interface IAccountService
    {
        Task<dynamic> Login(AccountLogin accountLogin);
        Task<AccountDto> Register(AccountCreateDto account);
    }
}
