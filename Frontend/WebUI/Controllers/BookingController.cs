using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
