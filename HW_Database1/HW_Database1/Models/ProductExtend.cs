using Microsoft.EntityFrameworkCore;

namespace HW_Database1.Models
{
    [Owned] 
    public class ProductExtend
    {
        public string Color { get; set; }
        public double Weight { get; set; }
    }
}
