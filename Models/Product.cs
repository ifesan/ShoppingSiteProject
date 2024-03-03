using System.Collections.Generic;
namespace ShoppingSite.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        // Foreign key property
        public int CategoryId { get; set; }

        // Navigation property for category
        public Category? Category { get; set; }

        // Navigation property for order details
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
