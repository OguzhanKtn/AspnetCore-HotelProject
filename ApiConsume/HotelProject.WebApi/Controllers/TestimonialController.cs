using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _TestimonialService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial()
        {
            return Ok();
        }
    }
}
