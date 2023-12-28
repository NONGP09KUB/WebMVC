
namespace OOWJANG.Service
{
    public interface IService
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
}
