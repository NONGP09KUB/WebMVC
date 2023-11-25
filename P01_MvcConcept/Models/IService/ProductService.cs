using System.Xml.Linq;
using System;
using P01_MvcConcept.Models.Setting;

namespace P01_MvcConcept.Models.IService
{
    public class ProductService : IProductService
    {
        public List<Product> ProductList { get; set; }
        public ProductService()
        {
            ProductList = new List<Product>();
            GenerateProduct(10);
        } 

        // สร้างสินค้า
        public void GenerateProduct(int number = 10)
        {
            for (int i = 1; i < number; i++)
            {
                Random r = new Random();
                var NumberOgName = NameOfProduct.ProductName.Count;
                ProductList.Add(new Product
                {
                    Id = i,
                    Name = NameOfProduct.ProductName[r.Next(NumberOgName)],
                    Price = r.NextDouble() * 100 + 1,
                    Amount = r.Next(100) + 1
                }) ;
                   
            }
        }
        // สร้างสินค้า end 


        // เรียกใช้ Product
        public List<Product> GetProductAll()
        {
            return ProductList;
        }
        // เรียกใช้ Product End 
    }
}
