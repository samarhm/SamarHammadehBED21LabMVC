using Microsoft.AspNetCore.Mvc;

namespace BED21Lab.Controllers
{
    public class HelloWorldController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
