using Core.Dto.Employee;

namespace HRM.Core.Interface.Service
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> GetAsync(Guid id);
        Task<List<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto> InsertAsync(EmployeeCreateDto employeeCreateDto);
        Task<EmployeeDto> UpdateAsync(EmployeeUpdateDto employeeUpdateDto, Guid id);
        Task<int> DeleteAsync(Guid id);
    }
}
