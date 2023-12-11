using Microsoft.AspNetCore.Mvc;

namespace HW_06._1.Controllers
{
    public class PlacesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
