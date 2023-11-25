using Microsoft.AspNetCore.Mvc;
using P01_MvcConcept.Models.IService;

namespace P01_MvcConcept.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var ps = new ProductService();
            ps.GenerateProduct(10);

            return View(ps.GetProductAll());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}   
