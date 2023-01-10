using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public interface IEmployeeData
    {
        Task<List<Employees>> GetEmployeesAsync();

        Employees GetEmployees(string code);

        Employees AddEmployee(Employees employee);

        void DeleteEmployee(Employees employee);

        Employees EditEmployee(Employees employee);
       
    }
}
