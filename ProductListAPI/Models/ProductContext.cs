using Microsoft.EntityFrameworkCore;

namespace ProductListAPI.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base (options)
        {

        }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductCostHistory> ProductCostHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Production");

            //Configure composite key
            modelBuilder.Entity<ProductCostHistory>().HasKey(table => new {
                table.StartDate,
                table.ProductID
            });
        }
    }
}
