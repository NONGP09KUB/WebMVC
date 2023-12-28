using System.ComponentModel.DataAnnotations.Schema;

namespace HW_Database1.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
