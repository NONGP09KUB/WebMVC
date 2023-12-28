
namespace OOWJANG.Service
{
    public class Service : IService
    {
        public List<Product> ProductList { get; set; }
        public Service()
        {
            ProductList = new List<Product>();
            GenerateProduct(5);
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
                    Price = r.Next(1,100),
                    ImageUrl = $"{}"
                });

            }
        }
        // สร้างสินค้า end 


        // เรียกใช้ Product
        public List<Product> GetProductAll()
        {
            return ProductList;
        }

        // การค้นหาสินค้า
        public Product SearchProduct(int id)
        {
            return ProductList.Find(x => x.Id == id);

        }

        // การเพิ่มสินค้า
        public void AddProduct(Product product)
        {
            ProductList.Add(product);
        }

        // การลบสินค้า
        public void DeleteProduct(int id)
        {
            var result = SearchProduct(id);
            if (result != null) { ProductList.Remove(result); }
        }

        // การแก้ไขสินค้า
        public void EditProduct(int id)
        {
            throw new NotImplementedException();
        }


        // กาารอัพเดตสินค้า
        public void UpdateProduct(Product product)
        {
            var oldProduct = ProductList.Find(p => p.Id == product.Id);
            var index = ProductList.IndexOf(oldProduct);
            if (index != -1)
            {
                ProductList.RemoveAt(index);
                ProductList.Insert(index, product);
            }

        }
    }
}
