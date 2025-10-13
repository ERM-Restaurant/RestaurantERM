//using Microsoft.AspNetCore.Mvc;

//namespace Restaurant_Project.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ProductController : ControllerBase
//    {
//        private readonly IProductService _productService;

//        public ProductController(IProductService productService)
//        {
//            _productService = productService;
//        }

//        [HttpGet("get-all")]
//        public IActionResult GetAll()
//        {
//            var products = _productService.GetAll();
//            return Ok(products);
//        }

//        [HttpGet("get-by-id/{id}")]
//        public IActionResult GetById(int id)
//        {
//            var product = _productService.GetById(id);
//            if (product == null)
//                return NotFound();

//            return Ok(product);
//        }

//        [HttpPost("add")]
//        public IActionResult Add(ProductDTO dto)
//        {
//            var addedProduct = _productService.Add(dto);
//            return CreatedAtAction(nameof(GetById), new { id = addedProduct.Id }, addedProduct);
//        }

//        [HttpPut("update/{id}")]
//        public IActionResult Update(int id, ProductDTO dto)
//        {
//            if (id != dto.Id)
//                return BadRequest();

//            _productService.Update(dto);
//            return NoContent();
//        }

//        [HttpDelete("delete/{id}")]
//        public IActionResult Delete(int id)
//        {
//            _productService.Delete(id);
//            return NoContent();
//        }
//    }
//}
