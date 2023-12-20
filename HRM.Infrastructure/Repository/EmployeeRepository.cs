using Core.Entity;
using HRM.Core.Interface.Repository;
using HRM.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private MySQLDBContext _dbContext;  
        public EmployeeRepository(MySQLDBContext dbContext)
        {
            _dbContext = dbContext; 
        }
     public async Task<int> DeleteAsync(Guid id)
        {
            var employeeExisted = await _dbContext.Employees.FindAsync(id);
            int rowEffected = 0; 
            if(employeeExisted != null)
            {
                _dbContext.Employees.Remove(employeeExisted);
                rowEffected = await _dbContext.SaveChangesAsync(); 
            }
            return rowEffected; 
        }

        public async Task<List<EmployeeEntity>> GetAllAsync()
        {
            return await _dbContext.Employees
                .Include(e => e.WorkInfo)
                .Include(e => e.Education)
                .Include(e => e.Experience)
                .Include(e => e.File)
                .Include(e => e.PermanentResidence)
                .Include(e => e.NowAddress)
                .Include(e => e.Hometown)
                .Include(e => e.UrgentContact)
                .Include(e => e.SalaryInfo)
                .Include(e => e.AllowanceSalary)
                .Include(e => e.DeductibleSalary)
                .ToListAsync();
        }

        public async Task<EmployeeEntity> GetAsync(Guid id)
        {
            var employeeExisted = await _dbContext.Employees.Include(e => e.WorkInfo)
                .Include(e => e.Education)
                .Include(e => e.Experience)
                .Include(e => e.File)
                .Include(e => e.PermanentResidence)
                .Include(e => e.NowAddress)
                .Include(e => e.Hometown)
                .Include(e => e.UrgentContact)
                .Include(e => e.SalaryInfo)
                .Include(e => e.AllowanceSalary)
                .Include(e => e.DeductibleSalary).FirstOrDefaultAsync(e => e.EmployeeId == id);
           
            return employeeExisted;
        }

        public async Task<int> InsertAsync(EmployeeEntity employeeEntity)
        {
            await _dbContext.Employees.AddAsync(employeeEntity);
            return await _dbContext.SaveChangesAsync();

        }

        public async Task<int> UpdateAsync(EmployeeEntity employeeEntity, Guid id)
        {
           var employeeUpdate = await _dbContext.Employees
                 .Include(e => e.WorkInfo)
                 .Include(e => e.Education)
                 .Include(e => e.Experience)
                 .Include(e => e.File)
                 .Include(e => e.PermanentResidence)
                 .Include(e => e.NowAddress)
                 .Include(e => e.Hometown)
                 .Include(e => e.UrgentContact)
                 .Include(e => e.SalaryInfo)
                 .Include(e => e.AllowanceSalary)
                 .Include(e => e.DeductibleSalary).FirstOrDefaultAsync(e => e.EmployeeId == id);
            if (employeeUpdate != null)
            {
                employeeUpdate.Code = employeeEntity.Code;
                employeeUpdate.Fullname = employeeEntity.Fullname;
                employeeUpdate.Gender = employeeEntity.Gender;
                employeeUpdate.IdentifyNumber = employeeEntity.IdentifyNumber;
                employeeUpdate.IdentifyType = employeeEntity.IdentifyType;
                employeeUpdate.IdentifyIssuedBy = employeeEntity.IdentifyIssuedBy;
                employeeUpdate.IdentifyDateRange = employeeEntity.IdentifyDateRange;
                employeeUpdate.TaxtCode = employeeEntity.TaxtCode;
                employeeUpdate.TaxtCodeDateRange = employeeEntity.TaxtCodeDateRange;
                employeeUpdate.TaxtCodeIssuedBy = employeeEntity.TaxtCodeIssuedBy; 
                employeeUpdate.PhoneNumber = employeeEntity.PhoneNumber;
                employeeUpdate.OrganEmail = employeeEntity.OrganEmail;
                employeeUpdate.PersonalEmail = employeeEntity.PersonalEmail; 
                employeeUpdate.Bank = employeeEntity.Bank;
                employeeUpdate.BankAccount = employeeEntity.BankAccount;
                employeeUpdate.Dob = employeeEntity.Dob; 
                employeeUpdate.WorkInfo = employeeEntity.WorkInfo;
                employeeUpdate.Education = employeeEntity.Education;
                employeeUpdate.Experience = employeeEntity.Experience;
                employeeUpdate.File = employeeEntity.File;
                employeeUpdate.PermanentResidence = employeeEntity.PermanentResidence;
                employeeUpdate.NowAddress = employeeEntity.NowAddress; 
                employeeUpdate.Hometown = employeeEntity.Hometown;
                employeeUpdate.UrgentContact = employeeEntity.UrgentContact;
                employeeUpdate.SalaryInfo = employeeEntity.SalaryInfo;
                employeeUpdate.AllowanceSalary = employeeEntity.AllowanceSalary;
                employeeUpdate.DeductibleSalary = employeeEntity.DeductibleSalary;            
            }
            return  await _dbContext.SaveChangesAsync();
            
        }
    }
}
