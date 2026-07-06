using _2_WebApi_Handson.Models;
using _2_WebApi_Handson.Services;
using Microsoft.AspNetCore.Mvc;

namespace _2_WebApi_Handson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAllEmployees());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = _service.GetById(id);
            if (employee == null) return NotFound("Employee not found");
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            _service.Add(employee);
            return Ok(_service.GetAllEmployees());
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee updated)
        {
            if (!_service.Update(id, updated))
                return BadRequest("Invalid ID");

            return Ok(_service.GetAllEmployees());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_service.Delete(id))
                return BadRequest("Invalid ID");

            return Ok(_service.GetAllEmployees());
        }
    }
}
