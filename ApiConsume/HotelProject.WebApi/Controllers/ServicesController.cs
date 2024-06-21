using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesService _servicesServices;

        public ServicesController(IServicesService servicesServices)
        {
            _servicesServices = servicesServices;
        }

        [HttpGet]
        public IActionResult ServicesList()
        {
            var values = _servicesServices.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddServices()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteServices()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateServices()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetServices()
        {
            return Ok();
        }
    }
}
