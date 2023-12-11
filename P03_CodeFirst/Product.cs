using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P03_CodeFirst
{
    public class Product
    {
        [DisplayName("รหัส")]
        public int Id { get; set; }

        [DisplayName("ชื่อ")]
        [Required(ErrorMessage =" กรุณาป้อนชื่อ ")]
        public string Name { get; set; }

        [DisplayName("ราคา")]
        [Required(ErrorMessage =" กรุณาป้อนข้อมูล ")]
        [Range(0,100,ErrorMessage ="ป้อนระหว่าง {1} => {100}")]
        public double Price { get; set; }

        [DisplayName("จำนวน")]
        [Required(ErrorMessage = " กรุณาป้อนข้อมูล ")]
        [Range(0, 100)]
        public int Amount { get; set; }

    }
}
