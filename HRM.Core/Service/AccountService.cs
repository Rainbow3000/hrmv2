﻿using AutoMapper;
using Core.Dto.Account;
using Core.Entity;
using Core.Exceptions;
using Core.Helper;
using Core.Interface.Repository;
using Core.Interface.Service;
using Microsoft.Extensions.Configuration;
using BC = BCrypt.Net.BCrypt;
namespace Core.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
      
        private readonly IConfiguration _configuration;
        public AccountService(IAccountRepository accountRepository, IMapper mapper, IConfiguration configuration)
        {
            //_accountRepository = accountRepository;
            //_mapper = mapper;
            //_configuration = configuration;
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AccountDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AccountDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDto> InsertAsync(AccountCreateDto entityCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> Login(AccountLogin accountLogin)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDto> Register(AccountCreateDto account)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDto> UpdateAsync(AccountUpdateDto entityUpdateDto, Guid id)
        {
            throw new NotImplementedException();
        }

        //public async Task<dynamic> Login(AccountLogin accountLogin)
        //{
        //    var accountExist = await _accountRepository.GetByEmailAsync(accountLogin.Email);
        //    if (accountExist == null)
        //    {
        //        throw new NotFoundException("Tài khoản không tồn tại.");
        //    }

        //    if (!BC.Verify(accountLogin.Password, accountExist.Password))
        //    {
        //        throw new AuthException("Mật khẩu không chính xác.");
        //    }

        //    return new
        //    {
        //        Success = true,
        //        UserName = accountExist.User.Name,
        //        AccountId = accountExist.AccountId,
        //        AccessToken = new JwtGenerateHelper(_configuration).GenerateToken(accountExist)
        //    };
        //}



        //public async Task<AccountDto> Register(AccountCreateDto accountCreateDto)
        //{
        //    var accountExist = await _accountRepository.GetByEmailAsync(accountCreateDto.Email);
        //    if (accountExist != null)
        //    {
        //        throw new DuplicateException("Tài khoản đã tồn tại.");
        //    }
        //    accountCreateDto.Password = BC.HashPassword(accountCreateDto.Password);
        //    accountCreateDto.AccountId = Guid.NewGuid();
        //    var account = _mapper.Map<Account>(accountCreateDto);
        //    account.Role = "USER";
        //    account.Status = 1;
        //    var accountResult = await _accountRepository.Register(account);
        //    var accountDto = _mapper.Map<AccountDto>(accountResult);
        //    return accountDto;
        //}
    }
}
