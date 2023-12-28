using HW_Database1.Areas.Identity.Data;
using HW_Database1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HW_Database1.Data;

public class Database1Context : IdentityDbContext<MyUser>
{
    public Database1Context(DbContextOptions<Database1Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
       
    }
    public DbSet<Product> Product {  get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Feature> Feature { get; set; }
    public DbSet<ProductDetails> ProductDetails { get; set; }
    public DbSet<ProductExtend> ProductExtend { get; set; }
    public DbSet<Component> Component { get; set; }

}
