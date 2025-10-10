using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDTO>> GetAll()
        {
            var employees = _employeeService.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeDTO> GetById(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
                return NotFound(new { message = $"Employee with ID {id} not found" });

            return Ok(employee);
        }

        [HttpPost]
        public ActionResult<EmployeeDTO> Add([FromBody] EmployeeDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = _employeeService.Add(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] EmployeeDTO dto)
        {
            if (id != dto.Id)
                return BadRequest(new { message = "ID mismatch" });

            var updated = _employeeService.Update(dto);
            if (!updated)
                return NotFound(new { message = $"Employee with ID {id} not found" });

            return Ok(new { message = "Employee updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _employeeService.Delete(id);
            if (!deleted)
                return NotFound(new { message = $"Employee with ID {id} not found" });

            return Ok(new { message = "Employee deleted successfully" });
        }
    }
}

