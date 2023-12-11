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
            var products = service.GetProductAll();
            return View(products);
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
            return View(service.GenerateProduct());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//var tst = new List<Product>()
//            {
//                new Product()
//                {
//                    Id = 1,
//                    Amount = 1,
//                    Name = "Test",
//                    Price = 1,
//                },
//                new Product()
//                {
//                    Id = 2,
//                    Amount = 1,
//                    Name = "Test",
//                    Price = 1,
//                }
//            };
//return View(tst);