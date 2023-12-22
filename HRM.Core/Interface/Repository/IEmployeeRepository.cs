using Core.Entity;
using HRM.Core.Dto.Filter;
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
        Task<List<EmployeeEntity>> GetAllAsync(FilterDto filterDto);  
        Task<EmployeeEntity> getByCode(string code);
        Task<int> InsertAsync(EmployeeEntity employeeEntity);  
        Task<int> UpdateAsync(EmployeeEntity employeeEntity, Guid id);  
        Task<int> DeleteAsync(Guid id);
    }
}
