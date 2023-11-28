using P02_Dependency_Injection.Models;

var builder = WebApplication.CreateBuilder(args);

// ============================================================================
// Add services to the container.
builder.Services.AddControllersWithViews();


// การปั่ม ที่ได้เหมือนเดิมทุกครั้ง เช่น นักศึกษา 10 คน ทานอาหาร 1 จาน  | สร้าง object แบบที่ 1 
//builder.Services.AddSingleton<ITest, Test>();


// การปั่ม  เช่น นักศึกษา 10 คน ทานอาหารเหมือนกัน 10 จาน
//builder.Services.AddScoped<ITest, Test>();


// แบบที่ 3 ไม่เหมือนกันเลยซักคนเดียว
builder.Services.AddTransient<ITest, Test>();



// =======================================================================
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
