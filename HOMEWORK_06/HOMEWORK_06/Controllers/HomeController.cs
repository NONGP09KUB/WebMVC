using HOMEWORK_06.Models;
using HOMEWORK_06.Service;
using HOMEWORK_06.Setting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HOMEWORK_06.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService service;

        public HomeController(IService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View(service.GetProductAll());

        }

        public IActionResult Product()
        {
            return View(service.GetProductAll());
        }
        
        public IActionResult commend()
        {
            var products = service.GetProductAll();
            return View(products);
        }

        
        public IActionResult ALLProduct()
        {

            //return View(service.GenerateProduct());
            return View(service.GetProductAll());

        }
        public IActionResult Delete(int id)
        {
            service.DeleteProduct(id);
            return RedirectToAction("ALLProduct");
        }
        public IActionResult Edit(int id)
        {
            var resualt = service.SearchProduct(id);
            if (resualt == null) { return RedirectToAction("ALLProduct"); }
            return View(resualt);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid) { return View(); }
            else { service.UpdateProduct(product); }
            return RedirectToAction("ALLProduct");
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

            var result = service.SearchProduct(product.Id);
            if (result == null)
            {
                service.AddProduct(product);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



