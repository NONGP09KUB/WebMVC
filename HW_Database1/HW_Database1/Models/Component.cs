namespace HW_Database1.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Product { get; set;}
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
