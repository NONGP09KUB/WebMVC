namespace P01_MvcConcept.Models.IService
{
    public interface IProductService 
    {
        void GenerateProduct(int number = 10);
        List<Product> GetProductAll();
    }
}
