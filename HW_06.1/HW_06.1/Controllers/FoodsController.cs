using Microsoft.AspNetCore.Mvc;

namespace HW_06._1.Controllers
{
    public class FoodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
