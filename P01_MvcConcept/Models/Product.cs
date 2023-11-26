using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P01_MvcConcept.Models
{
    public class Product
    {

        [DisplayName("รหัสผ่าน")]
        [Required(ErrorMessage = " กรุณากรอกข้อมูล ")]
        [Range(1, 999)]
        public int Id { get; set; }

        [DisplayName("ชื่อ")]
        [Required(ErrorMessage = " กรุณากรอกข้อมูล ")]
        [StringLength(100,MinimumLength = 1)]
        public string Name { get; set; }

        [DisplayName("ราคา")]
        [Range(1,double.MaxValue , ErrorMessage = "  อย่างน้อย {1} ถึง {2}")]
        public double Price { get; set; }

        [DisplayName("จำนวน")]
        [Range(1, 10000, ErrorMessage = "  อย่างน้อย {1} ถึง {2}" )]
        public int Amount { get; set; }

    }
}
