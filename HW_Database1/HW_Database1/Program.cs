using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HW_Database1.Data;
using HW_Database1.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Database1ContextConnection") ?? throw new InvalidOperationException("Connection string 'Database1ContextConnection' not found.");

builder.Services.AddDbContext<Database1Context>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MyUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 3;
}).AddEntityFrameworkStores<Database1Context>();

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

app.Run();
