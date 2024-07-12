using Core_HomeWork2.Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Core_HomeWork2.Data;

public class AppDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories {  get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

    }


}
