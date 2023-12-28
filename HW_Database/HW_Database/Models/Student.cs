using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW_Database.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }

        [DisplayName("คะแนนสอบ")]
        [Range(1, 999, ErrorMessage = "ป้อนค่าระหว่าง {1} ถึง {2}")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public int Score { get; set; }
    }
}
