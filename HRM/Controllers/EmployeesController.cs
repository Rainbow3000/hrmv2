using Controllers;
using Core.DataResponse;
using Core.Dto.Employee;
using Core.Interface.Service;
using Filter.Jwt;
using HRM.Core.Dto.Filter;
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
        //[ServiceFilter(typeof(UserTokenFilter))]
        public virtual async Task<DataResponse> GetAllAsync([FromQuery] FilterDto filterDto)
        {
            var entities = await _employeeService.GetAllAsync(filterDto);
            return new DataResponse(entities, StatusCodes.Status200OK);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(AdminTokenFilter))]
        [ServiceFilter(typeof(UserTokenFilter))]
        public virtual async Task<DataResponse> GetAsync(Guid id)
        {
            var entities = await _employeeService.GetAsync(id);
            return new DataResponse(entities, StatusCodes.Status200OK);
        }

        [HttpPost]
        //[ServiceFilter(typeof(AdminTokenFilter))]
        public virtual async Task<DataResponse> InsertAsync(EmployeeCreateDto employeeCreateDto)
        {
            var employeeDto = await _employeeService.InsertAsync(employeeCreateDto);
            return new DataResponse(employeeDto, StatusCodes.Status200OK);
        }
        [HttpPut("{id}")]
        [ServiceFilter(typeof(AdminTokenFilter))]
        public virtual async Task<DataResponse> UpdateAsync(EmployeeUpdateDto employeeUpdateDto,Guid id )
        {
            var employeeDto = await _employeeService.UpdateAsync(employeeUpdateDto,id);
            return new DataResponse(employeeDto, StatusCodes.Status200OK);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(AdminTokenFilter))]
        public virtual async Task<DataResponse> DeleteAsync(Guid id)
        {
            var employeeDto = await _employeeService.DeleteAsync(id);
            return new DataResponse(employeeDto, StatusCodes.Status200OK);
        }


    }
}
