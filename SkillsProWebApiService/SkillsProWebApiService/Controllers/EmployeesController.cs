using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillsProWebApiService.DataOperations;
using SkillsProWebApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsProWebApiService.Controllers
{
    
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employee;
        public EmployeesController(IEmployeeData employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetEmployees()
        {
            var emp = await _employee.GetEmployeesAsync();
            if (emp != null)
            {
                return Ok(emp);
            }
            else return NotFound("Employees Records not Found");
        }

        [HttpGet]
        [Route("api/[controller]/{code}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult GetEmployeesByCode(string code)
        {
            var emp = _employee.GetEmployees(code);
            if (emp != null)
            {
                return Ok(emp);
            }
            else return NotFound($"Employee Record with code: {code} was not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{code}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult UpdateEmployee(string code, Employees employee)
        {
            var existingEmp = _employee.GetEmployees(code);
            if (existingEmp != null)
            {
                employee.Code = existingEmp.Code;
                employee = _employee.EditEmployee(employee);
            }

            return Ok(employee);
            
        }

        [HttpDelete]
        [Route("api/[controller]/{code}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteEmployee(string code)
        {
            var existingEmp = _employee.GetEmployees(code);
            if (existingEmp != null)
            {
               _employee.DeleteEmployee(existingEmp);
                return Ok();
            }
            else return NotFound($"Employee Record with code: {code} was not Found");


        }

        [HttpPost]
        [Route("api/[controller]")]
        [Authorize(Roles = "Administrator")]
        public IActionResult AddEmployee(Employees employee)
        {
            _employee.AddEmployee(employee);

            return Ok(employee);

        }
    }
}
