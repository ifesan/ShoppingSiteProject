using Microsoft.EntityFrameworkCore;
using ShoppingSite.Models;

namespace ShoppingSite.Models
{
public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-one relationship between Order and Payment
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId)
                .IsRequired(false); // If a Payment is optional for an Order, set IsRequired(false)

            // Add any additional configuration for your model here
        }
    public DbSet<ShoppingSite.Models.User> User { get; set; } = default!;

        
	}

    




    
}
