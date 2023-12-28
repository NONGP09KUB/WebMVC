
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P03_CodeFirst.Data;

namespace P03_CodeFirst.SERVICE
{
    public class ProductService : IProductService
    {
        private readonly DataContext _db;
        public List<Product> ProductList;
        public ProductService(DataContext _db)
        {
            this._db = _db;
            ProductList = new List<Product>();
            if (_db.Products.Count() == 0 ) GenerateProduct(10);
        }

        public void Add(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void Delete(Product product)
        {
           _db.Products.Remove(product); // ลบใน memorr
           _db.SaveChanges(); // ลบจริงๆ 
                
        }

        public void GenerateProduct(int number = 10)
        {
            Random r = new Random();
            for (int i = 0; i <= number; i++)
            {
                ProductList.Add(new Product
                {
                    //Id = i,
                    Name = "Mile_" + i,
                    Price = r.Next(10, 100),
                    Amount = r.Next(1,100),    
                });
            }
            // วิธีการเอาข้อมูลลง database
            _db.Products.AddRange(ProductList);
            _db.SaveChanges(); // อันนี้ลง Harddis ไปเลย 
        }

        public IEnumerable<Product> GetAll()
        {
            
            return _db.Products.OrderByDescending(p => p.Id).ToList();
        }

        public Product GetbyId(int id)
        {
            var product = _db.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public void Update(Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
        }
    }
}
