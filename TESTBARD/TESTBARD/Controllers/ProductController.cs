using Microsoft.AspNetCore.Mvc;

namespace TESTBARD.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            List<Product> products = _productRepository.GetAll();

            return View(products);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Product product = _productRepository.GetById(id);

            return View(product);
        }

        public ActionResult Delete(int id)
        {
            _productRepository.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Save(Product product)
        {
            if (product.Id == 0)
            {
                _productRepository.Add(product);
            }
            else
            {
                _productRepository.Update(product);
            }

            return RedirectToAction("Index");
        }
    }
}
