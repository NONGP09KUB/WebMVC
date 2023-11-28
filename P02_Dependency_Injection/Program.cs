using P02_Dependency_Injection.Models;

var builder = WebApplication.CreateBuilder(args);

// ============================================================================
// Add services to the container.
builder.Services.AddControllersWithViews();


// ��û��� ���������͹����ء���� �� �ѡ�֡�� 10 �� �ҹ����� 1 �ҹ  | ���ҧ object Ẻ��� 1 
//builder.Services.AddSingleton<ITest, Test>();


// ��û���  �� �ѡ�֡�� 10 �� �ҹ���������͹�ѹ 10 �ҹ
//builder.Services.AddScoped<ITest, Test>();


// Ẻ��� 3 �������͹�ѹ��«ѡ������
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
