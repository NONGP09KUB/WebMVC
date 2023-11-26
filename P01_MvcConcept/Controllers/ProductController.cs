using Microsoft.AspNetCore.Mvc;
using P01_MvcConcept.IService;
using P01_MvcConcept.Models;

namespace P01_MvcConcept.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ps;

        // เรียกใช้ Dependency injection ผ่าน Contructor
        public ProductController(IProductService ps)
        {
            this.ps = ps;
        }
        
        public IActionResult Index()
        {
            return View(ps.GetProductAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        //ต้องใช้ตัวนี้เพื่อทราบว่าต้องการ Post ตัวนี้คือปลายทาง ส่งมาจาก Create

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid) { return View();  }

            var result = ps.SearchProduct(product.Id);
            if ( result == null)
            {
                ps.AddProduct(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult  Delete(int id)
        {
            ps.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}   
