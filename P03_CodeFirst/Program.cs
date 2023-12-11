using P03_CodeFirst.Data;
using P03_CodeFirst.SERVICE;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// การฉีดข้อมูลให้ใช้ได้ทุกหน้า ( DataContext เอามาจากหน้าที่สร้าง Class )    DataContext.cs <=
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<IProductService, ProductService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
