using Microsoft.EntityFrameworkCore;
using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public class EmployeeData : IEmployeeData
    {
        private SkillsProDBContext _context;
        public EmployeeData(SkillsProDBContext context)
        {
            _context = context;
        }
        public Employees AddEmployee(Employees employee)
        {
            if (string.IsNullOrEmpty(employee.Code))
            {
                employee.Code = "emp" + Guid.NewGuid();
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employees employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employees EditEmployee(Employees employee)
        {
            var existingEmployee = GetEmployees(employee.Code);
            existingEmployee.Name = employee.Name;
            //existingEmployee.AnnualSalary = employee.AnnualSalary;
            //existingEmployee.DateOfBirth = employee.DateOfBirth;
            //existingEmployee.Gender = employee.Gender;
            _context.SaveChanges();
            return existingEmployee;
        }

        
        public Employees GetEmployees(string code)
        {
            var emp = _context.Employees.Find(code);

            return emp;
        }

        public string GetEmployeeNameByCode(string code)
        {
            var emp = _context.Employees.Find(code);

            return emp.Name;
        }

        public async Task<List<Employees>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
