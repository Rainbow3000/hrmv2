using Core.Entity;

namespace Core.Interface.Repository
{
    public interface IAccountRepository
    {
        Task<int> Register(AccountEntity account);
        Task<AccountEntity> GetByUserNameAsync(string userName);
    }
}
