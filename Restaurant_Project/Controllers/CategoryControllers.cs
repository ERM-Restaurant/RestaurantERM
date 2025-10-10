using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("Get All Categories")]
        public IActionResult GetAll()
        {
            var category = _categoryService.GetAll();
            return Ok(category);
        }

        [HttpGet("Get Categories by id")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpPost("Add Category")]
        public IActionResult Add(CategoryDTO dto)
        {
            var addedCategory = _categoryService.Add(dto);
            return CreatedAtAction(nameof(GetById), new { id = addedCategory.Id }, addedCategory);
        }

        [HttpPut("Update Category")]
        public IActionResult Update(int id, CategoryDTO dto)
        {
            if (id != dto.Id)
                return BadRequest();

            _categoryService.Update(dto);
            return NoContent();
        }

        [HttpDelete("Delete Category")]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return NoContent();
        }
    }
}

