using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Models.Staff;

namespace WebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:10881/api/Staff");

            if(responseMessage.IsSuccessStatusCode) 
            { 
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);    
                return View(values);
            }

            return View();
        }
    }
}
