
using P01_MvcConcept.IService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.( ���ŧ����¹ )
builder.Services.AddControllersWithViews();

//Dependency injection ��éմ����������� ( ŧ����¹���� )
builder.Services.AddSingleton<IProductService,ProductService>();




// Midle ware ( ����͹�Ѻ ��� ��Ǩ�ͺ��Ҩ�ҧ � )
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
// Midle ware End