using HW_Database.Data;
using HW_Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_Database.Controllers
{

    public class ProductController : Controller
    {
        private readonly HW_DatabaseContext db;

        public ProductController(HW_DatabaseContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> allstuden = db.Students;
            return View(allstuden);
        }
        //ปกติ เป็น Get method 
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Allstudent = db.Students.Find(id); 
            if (Allstudent == null)
            {
                return NotFound();
            }
            db.Students.Remove(Allstudent);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }



        public IActionResult Edits(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Allstudent = db.Students.Find(id);
            if (Allstudent == null)
            {
                return NotFound();
            }
            return View(Allstudent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edits(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Update(student);
                db.SaveChanges(); // บันทึกเข้า database
                return RedirectToAction("Index"); // เปลี่ยนหน้าเสร็จกลับมาหน้านี้
            }
            else
            {
                return View(student);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges(); // บันทึกเข้า database
                return RedirectToAction("Index"); // เปลี่ยนหน้าเสร็จกลับมาหน้านี้
            }
            else
            {
                return View(student);
            }
        }
    }
}
