using P01_MvcConcept.Models;

namespace P01_MvcConcept.IService
{
    public interface IProductService
    {
        void GenerateProduct(int number = 10);
        List<Product> GetProductAll();

        Product SearchProduct(int id);

        void AddProduct(Product product);

        void DeleteProduct(int id);
        void EditProduct(int id);
        void UpdateProduct(Product product);
    }
}
