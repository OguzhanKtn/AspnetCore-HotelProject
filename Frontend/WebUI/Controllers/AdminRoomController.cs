using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
