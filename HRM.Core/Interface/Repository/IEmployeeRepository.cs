using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Interface.Repository
{
    public interface IEmployeeRepository
    {
        Task<EmployeeEntity> GetAsync(Guid id);  
        Task<List<EmployeeEntity>> GetAllAsync();  
        Task<int> InsertAsync(EmployeeEntity employeeEntity);  
        Task<int> UpdateAsync(EmployeeEntity employeeEntity, Guid id);  
        Task<int> DeleteAsync(Guid id);
    }
}
