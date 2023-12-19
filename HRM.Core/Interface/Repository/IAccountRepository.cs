using Core.Entity;

namespace Core.Interface.Repository
{
    public interface IAccountRepository
    {
        Task<Account> Register(Account account);
        Task<Account> GetByEmailAsync(string email);
    }
}
