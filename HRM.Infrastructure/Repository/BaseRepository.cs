using AutoMapper;
using Core.Interface.Repository;
using HRM.Infrastructure.DataAccess;

namespace Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        private readonly MySQLDBContext _databaseContext;
        private readonly IMapper _mapper;
        private string entityName = typeof(TEntity).Name;
        public BaseRepository(MySQLDBContext databaseContext,IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper; 
        }  
    }
}
