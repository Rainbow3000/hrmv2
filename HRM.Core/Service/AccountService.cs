using AutoMapper;
using Core.Dto.Account;
using Core.Entity;
using Core.Exceptions;
using Core.Helper;
using Core.Interface.Repository;
using Core.Interface.Service;
using HRM.Core.Helper;
using HRM.Core.Interface.Repository;
using Microsoft.Extensions.Configuration;
using BC = BCrypt.Net.BCrypt;
namespace Core.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public AccountService(IAccountRepository accountRepository, IEmployeeRepository employeeRepository, IMapper mapper, IConfiguration configuration)
        {
            _accountRepository = accountRepository;
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _configuration = configuration;
        }





        public async Task<dynamic> Login(AccountLoginDto accountLogin)
        {
            var accountExist = await _accountRepository.GetByUserNameAsync(accountLogin.UserName);
            if (accountExist == null)
            {
                throw new NotFoundException("Tài khoản không tồn tại.");
            }

            if (!BC.Verify(accountLogin.Password, accountExist.Password))
            {
                throw new AuthException("Mật khẩu không chính xác.");
            }

            return new
            {
                Success = true,
                UserName = accountExist.UserName,
                AccountId = accountExist.AccountId,
                Role = accountExist.Role,
                AccessToken = new JwtGenerateHelper(_configuration).GenerateToken(accountExist)
            };
        }


        public async Task<AccountDto> Register(AccountCreateDto accountCreateDto)
        {
            var accountExist = await _accountRepository.GetByUserNameAsync(accountCreateDto.UserName);
            if (accountExist != null)
            {
                throw new DuplicateException("Tài khoản đã tồn tại.");
            }
          
            if(accountExist?.EmployeeId == accountCreateDto.EmployeeId)
            {
                throw new DuplicateException("Nhân viên đã có tài khoản"); 
            }
            var employeeExist = await _employeeRepository.GetAsync(accountCreateDto.EmployeeId); 

            if (employeeExist == null)
            {
                throw new NotFoundException("Nhân viên không tồn tại.");
            }

            var account = _mapper.Map<AccountEntity>(accountCreateDto);
            account.AccountId = Guid.NewGuid();
            account.Password = BC.HashPassword(accountCreateDto.Password);
            account.Role = "USER";
            account.Status = 1;
            account.UserName = TextHelper.ReplaceWhitespace(account.UserName, "").ToLower();
            var response = await _accountRepository.Register(account);
            var accountDto = _mapper.Map<AccountDto>(account);
            return accountDto;
        }
    }
}
