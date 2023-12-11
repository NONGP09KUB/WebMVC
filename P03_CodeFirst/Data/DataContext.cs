using Microsoft.EntityFrameworkCore;

namespace P03_CodeFirst.Data
{
    // การสืบทอด ขาก framework ที่ติดตั้งมา 
    public class DataContext : DbContext    
    {
        // ในวงเล็บคือ พารามิเตอร์ ที่ชื่อว่า options => ใช้ชื่ออะไรก็ได้
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // UseSqlServer มาจากตัวที่ติดตั้ง 
            // ("Server=DESKTOP-3268S1F\\SQLEXPRESS"); ใส่แบบนิใช้ได้แค่เครื่องที่สร้าง
            // Trusted_Connection=True; TrustServerCertificate=True" อันนิ ต้องใส่ให้ถูกเท่านั้น เป๊ะ
            optionsBuilder.UseSqlServer(" Server=.\\SQLEXPRESS; Database=SamongLai; Trusted_Connection=True; TrustServerCertificate=True ");
            //optionsBuilder.UseSqlite("Data source=Test99");
        }

        // เอาข้อมูลตัวนี้ไปสร้าง Database 
        public DbSet<Product> Products { get; set; }
    }
}

// Class ดึงไปใช้เฉย ๆ ไม่ได้ ต้องเอาไปฉีดก่อน ( ที่หน้า Programe )   => Programe 