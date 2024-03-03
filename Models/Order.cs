using System.Collections.Generic;
namespace ShoppingSite.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign key property
        public int? PaymentId { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public Payment? Payment { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
