namespace P03_CodeFirst.SERVICE
{
    public interface IProductService
    {
        void GenerateProduct( int number );
        IEnumerable<Product> GetAll( );

        Product GetbyId( int id );

        void Delete(Product product);

        void Add(Product product);
        void Update(Product product);
    }
}
