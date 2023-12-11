using Microsoft.AspNetCore.Mvc;

namespace HW_06._1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
