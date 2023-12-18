using Core.Entity;

namespace Core.Interface.Repository
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        //Task<Account> Register(Account account);
        //Task<Account> GetByEmailAsync(string email);
    }
}
