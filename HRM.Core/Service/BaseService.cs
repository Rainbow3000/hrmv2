using AutoMapper;
using Core.Helper;
using Core.Interface.Repository;
using Core.Interface.Service;

namespace Core.Service
{
    public class BaseService<TEntity, TEntityDto, TEntityCreateDto, TEntityUpdateDto> : IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>
    {

        private readonly IBaseRepository<TEntity> _baseRepository;
        protected readonly IMapper _mapper;
        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        //public virtual async Task<int> DeleteAsync(Guid id)
        //{
        //    string sql = SqlQueryHelper<TEntity>.DeleteSqlMethod();
        //    return await _baseRepository.DeleteAsync(sql, id);
        //}

        //public async Task<List<TEntityDto>> GetAllAsync()
        //{
        //    string sql = SqlQueryHelper<TEntity>.GetSqlMethod();
        //    string entityName = typeof(TEntity).Name;

        //    var entities = await _baseRepository.GetAllAsync(sql, x => DataMappingHelper<TEntity>.DataMapper(x, _mapper));
        //    var entitiesDto = _mapper.Map<List<TEntityDto>>(entities);
        //    return entitiesDto;
        //}

        //public virtual async Task<TEntityDto> GetAsync(Guid id)
        //{

        //    var sql = SqlQueryHelper<TEntity>.GetSqlMethod();
        //    var entity = await _baseRepository.GetAsync(sql, id, x => DataMappingHelper<TEntity>.DataMapper(x, _mapper)!);
        //    var entityDto = _mapper.Map<TEntityDto>(entity);
        //    return entityDto;
        //}

        //public virtual async Task<TEntityDto> InsertAsync(TEntityCreateDto entityCreateDto)
        //{
        //    var entity = _mapper.Map<TEntity>(entityCreateDto);
        //    var (sql, parameters) = SqlQueryHelper<TEntity>.InsertSqlMethod(entity);
        //    await _baseRepository.InsertAsync(sql, parameters);
        //    var entityDto = _mapper.Map<TEntityDto>(entity);
        //    return entityDto;

        //}

        //public virtual async Task<TEntityDto> UpdateAsync(TEntityUpdateDto entityUpdateDto, Guid id)
        //{
        //    var entity = _mapper.Map<TEntity>(entityUpdateDto);
        //    var (sql, parameters) = SqlQueryHelper<TEntity>.UpdateSqlMethod(entity);
        //    await _baseRepository.UpdateAsync(sql, parameters, id);
        //    var entityDto = _mapper.Map<TEntityDto>(entity);
        //    return entityDto;
        //}
    }
}
