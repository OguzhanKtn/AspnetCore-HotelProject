using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
