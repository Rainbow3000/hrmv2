using AutoMapper;
using Core.Entity;
using Core.Interface.Repository;
using HRM.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace HomeFinder.Infrastructure.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly MySQLDBContext _dbContext;
        private readonly IMapper _mapper;
        public AccountRepository(MySQLDBContext dbContext, IMapper mapper)
        {
             _dbContext = dbContext;
             _mapper = mapper;
        }

        public async Task<AccountEntity> GetByUserNameAsync(string userName)
        {
            return await _dbContext.Accounts.FirstOrDefaultAsync(a => a.UserName == userName); 
        }
        public async Task<int> Register(AccountEntity account)
        {
            var data =  await _dbContext.Accounts.AddAsync(account);

            return await _dbContext.SaveChangesAsync();
        }
    }
}
