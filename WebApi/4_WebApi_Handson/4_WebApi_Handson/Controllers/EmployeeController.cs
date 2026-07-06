using Microsoft.AspNetCore.Mvc;
using _4_WebApi_Handson.Models;
using System.Linq;

namespace _4_WebApi_Handson.Controllers
{
    [Route("api/emp4")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(EmployeeData.Employees);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmp = EmployeeData.Employees.FirstOrDefault(e => e.Id == id);

            if (existingEmp == null)
                return BadRequest("Invalid employee id");

            existingEmp.Name = updatedEmp.Name;
            existingEmp.Salary = updatedEmp.Salary;
            existingEmp.Permanent = updatedEmp.Permanent;
            existingEmp.Department = updatedEmp.Department;
            existingEmp.Skills = updatedEmp.Skills;
            existingEmp.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(existingEmp);
        }
    }
}
