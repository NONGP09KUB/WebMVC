using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            var product = new List<Product>()
            {
                new Product() {Id = 1 , Name = "COS" , Amount = 100 , Price = 100},
                new Product() {Id = 2 , Name = "44141" , Amount = 1004 , Price = 1400},
            };
            // ตอนนี้ส่งได้อย่างเดียว 
            return View(new { product, Title = "Coffee" });
            // ถ้ามี ตัวนิ { } เท่ากับ object สมารถส่งได้หลายอย่าง
        }
    }
}
