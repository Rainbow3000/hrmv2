using AutoMapper;
using Core.Entity;
using Core.Interface.Repository;
using HRM.Infrastructure.DataAccess;

namespace HomeFinder.Infrastructure.Repository
{
    public class AccountRepository
    {
        private readonly MySQLDBContext _databaseContext;
        private readonly IMapper _mapper;
        public AccountRepository(MySQLDBContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }
    }
}
