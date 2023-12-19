using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Interface.Repository
{
    public interface BaseRepository <TEntity>
    {
        Task<TEntity> GetAsync(Guid id);
        Task<TEntity> GetAllAsync();
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> DeleleAsync(Guid id);

    }
}
