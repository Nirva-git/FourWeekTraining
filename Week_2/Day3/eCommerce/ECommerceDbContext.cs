using Microsoft.EntityFrameworkCore;
using eCommerce.Models;

namespace eCommerce
{
    public class ECommerceDbContext: DbContext
    {
        /*public ECommerceDbContext()
        {
        }*/

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
