using Microsoft.AspNetCore.Mvc;
using P02_Dependency_Injection.Models;

namespace P02_Dependency_Injection.Controllers
{
    public class TestDependencyController : Controller
    {
        private readonly ITest test;
        private readonly ITest test1;

        public TestDependencyController(ITest test , ITest test1)
        {
            this.test = test;
            this.test1 = test1;
        }

        // =================================================================

        // แบบ Singleton
        public IActionResult Index()
        {
            // ที่ไม่เห็น Data เพราะ ไม่ได้ใส่  public ที่ Test 
            return View(test.GenerateData());
        }
        public IActionResult Index1()
        {
            var group = new {data1 = test.GenerateData(), data2 = test1.GenerateData() };
            return View(group);
        }

        public IActionResult Index2()
        {
            // ที่ไม่เห็น Data เพราะ ไม่ได้ใส่  public ที่ Test 
            return View(test.GenerateData());
        }
        // =================================================================


    }
}
