using AutoMapper;
using Core.Entity;
using Core.Interface.Repository;
using HRM.Infrastructure.DataAccess;
using Infrastructure.Repository;

namespace HomeFinder.Infrastructure.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        private readonly MySQLDBContext _databaseContext;
        private readonly IMapper _mapper;
        public AccountRepository(MySQLDBContext databaseContext, IMapper mapper) : base(databaseContext, mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }
    }
}
