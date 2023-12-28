using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mini_Project_MVC.Areas.Identity.Data;
using Mini_Project_MVC.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Mini_ProjectContextConnection") ?? throw new InvalidOperationException("Connection string 'Mini_ProjectContextConnection' not found.");

builder.Services.AddDbContext<Mini_ProjectContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MyUser>(options => {


    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 3;
    // ต้องใส่ตั้งนี้ถึงจะรันได้ 
}).AddRoles<IdentityRole>()
.AddEntityFrameworkStores<Mini_ProjectContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapRazorPages();
app.Run();
