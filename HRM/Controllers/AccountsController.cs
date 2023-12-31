﻿
using Core.DataResponse;
using Core.Dto.Account;
using Core.Interface.Service;
using Filter.Jwt;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController 
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
       
        }

        [HttpPost("Register")]
        public async Task<DataResponse> Register([FromBody] AccountCreateDto accountCreateDto)
        {
            var account = await _accountService.Register(accountCreateDto);
            return new DataResponse(account, StatusCodes.Status201Created);
        }

        [HttpPost("Login")]
        public async Task<DataResponse> Login([FromBody] AccountLoginDto accountLogin)
        {
            var account = await _accountService.Login(accountLogin);
            return new DataResponse(account, StatusCodes.Status200OK);
        }

        //[ServiceFilter(typeof(AdminTokenFilter))]
        //public override Task<DataResponse> GetAllAsync()
        //{
        //    return base.GetAllAsync();
        //}

    }
}
