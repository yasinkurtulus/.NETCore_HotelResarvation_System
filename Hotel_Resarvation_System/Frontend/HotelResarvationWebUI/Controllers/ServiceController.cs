using HotelResarvationWebUI.Dtos.ServiceDto;
using HotelResarvationWebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelResarvationWebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMassage = await client.GetAsync("https://localhost:44382/api/Service");
            if (responseMassage.IsSuccessStatusCode)
            {
                var jsondata = await responseMassage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ListServiceDto>>(jsondata);
                return View(values);

            }
            return View();
        }
    }
}
