using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet("Get All tables")]
        public IActionResult GetAll()
        {
            var tables = _tableService.GetAll();
            return Ok(tables);
        }

        [HttpGet("Get tables by id")]
        public IActionResult GetById(int id)
        {
            var table = _tableService.GetById(id);
            if (table == null)
                return NotFound();

            return Ok(table);
        }

        [HttpPost("Add tables")]
        public IActionResult Add(TableDTO dto)
        {
            var addedTables = _tableService.Add(dto);
            return CreatedAtAction(nameof(GetById), new { id = addedTables.Id });
        }

        [HttpPut("Update tables")]
        public IActionResult Update(int id, TableDTO dto)
        {
            if (id != dto.Id)
                return BadRequest();

            _tableService.Update(dto);
            return NoContent();
        }

        [HttpDelete("Delete tables")]
        public IActionResult Delete(int id)
        {
            _tableService.Delete(id);
            return NoContent();
        }
    }
}
