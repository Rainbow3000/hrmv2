using Controllers;
using Core.DataResponse;
using Core.Dto.Employee;
using Core.Interface.Service;
using HRM.Core.Interface.Repository;
using HRM.Core.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService; 
        public EmployeesController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService; 
        }

        [HttpGet]
        public virtual async Task<DataResponse> GetAllAsync()
        {
            var entities = await _employeeService.GetAllAsync();
            return new DataResponse(entities, StatusCodes.Status200OK);
        }

        [HttpGet("{id}")]
        public virtual async Task<DataResponse> GetAsync(Guid id)
        {
            var entities = await _employeeService.GetAsync(id);
            return new DataResponse(entities, StatusCodes.Status200OK);
        }

        [HttpPost]
        public virtual async Task<DataResponse> InsertAsync(EmployeeCreateDto employeeCreateDto)
        {
            var employeeDto = await _employeeService.InsertAsync(employeeCreateDto);
            return new DataResponse(employeeDto, StatusCodes.Status200OK);
        }
        [HttpPut("{id}")]
        public virtual async Task<DataResponse> UpdateAsync(EmployeeUpdateDto employeeUpdateDto,Guid id )
        {
            var employeeDto = await _employeeService.UpdateAsync(employeeUpdateDto,id);
            return new DataResponse(employeeDto, StatusCodes.Status200OK);
        }

        [HttpDelete("{id}")]
        public virtual async Task<DataResponse> DeleteAsync(Guid id)
        {
            var employeeDto = await _employeeService.DeleteAsync(id);
            return new DataResponse(employeeDto, StatusCodes.Status200OK);
        }


    }
}
