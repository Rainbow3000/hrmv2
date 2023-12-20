using AutoMapper;
using Core.Dto.Account;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapper
{
    public class AccountProfile:Profile
    {
        public AccountProfile()
        {
            CreateMap<AccountEntity, AccountDto>();
            CreateMap<AccountUpdateDto, AccountEntity>();
            CreateMap<AccountCreateDto,AccountEntity>();
        }
    }
}
