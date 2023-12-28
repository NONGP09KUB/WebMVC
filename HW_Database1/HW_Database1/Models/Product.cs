using System.ComponentModel.DataAnnotations;

namespace HW_Database1.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public ProductExtend ProductExtend { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductDetails> ProductDetails { get; set; }
        public List<Component> Components { get; set; }
    }
}
