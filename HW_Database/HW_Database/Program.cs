using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HW_Database.Data;
using HW_Database.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("HW_DatabaseContextConnection") ?? throw new InvalidOperationException("Connection string 'HW_DatabaseContextConnection' not found.");

builder.Services.AddDbContext<HW_DatabaseContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<MyUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 3;
}).AddEntityFrameworkStores<HW_DatabaseContext>();

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
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
