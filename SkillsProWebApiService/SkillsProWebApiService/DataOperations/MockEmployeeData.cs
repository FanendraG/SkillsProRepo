using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.DataOperations
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employees> sample = new List<Employees>()
        {
             new Employees()
             {
               Code = "Emp101",
               AnnualSalary = 20000,
               Gender="M",
               Name="Fanendra Ganti",
                DateOfBirth ="05/20/1982"
               }
         };

        public Employees AddEmployee(Employees employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employees employee)
        {
            throw new NotImplementedException();
        }

        public Employees EditEmployee(Employees employee)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetEmployees()
        {
            return sample;
        }

        public Employees GetEmployees(string code)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employees>> GetEmployeesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
