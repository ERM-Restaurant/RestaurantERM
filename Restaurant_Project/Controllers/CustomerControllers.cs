//using Microsoft.AspNetCore.Mvc;

//namespace Restaurant_Project.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class CustomerController : ControllerBase
//    {
//        private readonly ICustomerService _customerService;

//        public CustomerController(ICustomerService customerService)
//        {
//            _customerService = customerService;
//        }

//        [HttpGet("get-all")]
//        public IActionResult GetAll()
//        {
//            var customers = _customerService.GetAll();
//            return Ok(customers);
//        }

//        [HttpGet("get-by-id/{id}")]
//        public IActionResult GetById(int id)
//        {
//            var customers = _customerService.GetById(id);
//            if (customers == null)
//                return NotFound();

//            return Ok(customers);
//        }

//        [HttpPost("add")]
//        public IActionResult Add(CustomerDTO dto)
//        {
//            var addCustomer = _customerService.Add(dto);
//            return CreatedAtAction(nameof(GetById), new { id = addCustomer.Id }, addCustomer);
//        }

//        [HttpPut("update/{id}")]
//        public IActionResult Update(int id, CustomerDTO dto)
//        {
//            if (id != dto.Id)
//                return BadRequest();

//            _customerService.Update(dto);
//            return NoContent();
//        }

//        [HttpDelete("delete/{id}")]
//        public IActionResult Delete(int id)
//        {
//            _customerService.Delete(id);
//            return NoContent();
//        }

//    }
//}

