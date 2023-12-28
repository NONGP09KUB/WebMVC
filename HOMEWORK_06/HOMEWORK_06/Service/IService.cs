using HOMEWORK_06.Models;

namespace HOMEWORK_06.Service
{
    public interface IService
    {
        List<Product> GenerateProduct(int number );
        List<Product> GetProductAll();

        Product SearchProduct(int id);

        void AddProduct(Product product);
        void DeleteProduct(int id);
        void EditProduct(int id);
        void UpdateProduct(Product product);
    }
}
