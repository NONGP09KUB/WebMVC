using HOMEWORK_06.Models;
using HOMEWORK_06.Setting;
using Microsoft.AspNetCore.Http.HttpResults;
using System;

namespace HOMEWORK_06.Service
{
    public class Service : IService
    {
        public List<Product> ProductList { get; set; }
        public Service()
        {
            ProductList = new List<Product>();
            GenerateProduct(4);
        }

      
        // รับ สินค้า
        public void AddProduct(Product product)
        {
                ProductList.Add(product);
        }
        // =======================================================================================


        // เก็บสินค้าทั้งหมด
        public List<Product> GetProductAll()
        {
            return ProductList;
        }
        // =======================================================================================


        // สร้างสินค้า
        public List<Product> GenerateProduct(int number )
        {
            var productCount = NameProduct.nameProduct.Count;
            for (int i = 0; i < number; i++)
            {
                Random r = new Random();
                ProductList.Add(new Product
                {
                    Id = i,
                    Name = NameProduct.nameProduct[i],
                    Price = r.Next(1, 50),
                    Amount = r.Next(1, 50),
                    ImageUrl = $"https://picsum.photos/110/50?{r.Next(1, 9999)}"
                });
            }

          
            return ProductList;
        }

        // =======================================================================================

        // แก้ไขสินค้า
        public void EditProduct(int id)
        {
            throw new NotImplementedException();
        }
        // =======================================================================================

        // ลบสินค้าที่เลือก
        public void DeleteProduct(int id)
        {
            var productIndex = ProductList.FindIndex(p => p.Id == id);
            if (productIndex >= 0)
            {
                ProductList.RemoveAt(productIndex);
            }
            
        }

        // =======================================================================================

        //  ค้นหาสินค้าทั้งหมด
        public Product SearchProduct(int id)
        {
            return ProductList.Find(x => x.Id == id);

        }
        // =======================================================================================

        // อัพเดตสินค้าทั้งหมดให้เป้นปัจจุบัน
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
