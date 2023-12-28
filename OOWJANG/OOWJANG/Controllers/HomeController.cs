using Microsoft.AspNetCore.Mvc;
using OOWJANG.Models;
using OOWJANG.Service;
using System.Diagnostics;

namespace OOWJANG.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeController ps;

        // เรียกใช้ Dependency injection ผ่าน Contructor
        public HomeController(IService ps)
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
            if (!ModelState.IsValid) { return View(); }

            var result = ps.SearchProduct(product.Id);
            if (result == null)
            {
                ps.AddProduct(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ps.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var resualt = ps.SearchProduct(id);
            if (resualt == null) { return RedirectToAction("Index"); }
            return View(resualt);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid) { return View(); }
            else { ps.UpdateProduct(product); }
            return RedirectToAction("Index");
        }
    }
}
