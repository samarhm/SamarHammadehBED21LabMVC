using Microsoft.AspNetCore.Mvc;

namespace BED21Lab.Controllers
{
    public class PhotosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()   
        {
            return View();
        }
        public IActionResult Cosmos()
        {
            return View();
        }
        public IActionResult Dahlia ()
        {
            return View();
        }
        public IActionResult Lotus()    
        {

            return View();
        }
        //use parameter to pass in photo id
        public IActionResult photoView(string id)
        {
            ViewBag.photo = id;
            return View();
        }
    }
}
