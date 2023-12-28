using Microsoft.AspNetCore.Mvc;
using P03_CodeFirst.SERVICE;

namespace P03_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductService ps;
        public ProductController(IProductService ps)
        {
            this.ps = ps;
        }

        public IActionResult Index()
        {
            var product = ps.GetAll();
            return View(product);
        }

        public IActionResult Delete(int id )
        {
            var product = ps.GetbyId(id);
            if(product == null)
            {
                TempData["OK"] = true;  // นำไปใช้ที่หน้า view ชั่วคราว
            }
            else
            {
                ps.Delete(product);
            }
            return RedirectToAction("Index");
        }

        
        public IActionResult Create() 
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                ps.Add(product);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Edit(int id)
        {
            var product = ps.GetbyId(id);
            if (product == null)
            {
                TempData["OK"] = true;  // นำไปใช้ที่หน้า view ชั่วคราว
            }

               return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ps.Update(product);
            return RedirectToAction("Index");
        }

    }
}
