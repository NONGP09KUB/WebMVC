using HOMEWORK_06.Models;

namespace HOMEWORK_06.Service
{
    public interface IService
    {
        List<Product> GenerateProduct(int number = 5);
        List<Product> GetProductAll(int number = 5);

        Product SearchProduct(int id);

        void AddProduct(Product product);
        void DeleteProduct(int id);
        void EditProduct(int id);
        void UpdateProduct(Product product);
    }
}
