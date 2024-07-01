using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminRoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            var client = _httpClientFactory.CreateClient();

            return View();
        }
    }
}
