using Microsoft.AspNetCore.Mvc;

namespace Student_Operations_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
