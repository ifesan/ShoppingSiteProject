using System.Collections.Generic;
using System.Text.Json.Serialization;
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
        [JsonIgnore]
        public User? User { get; set; }

        [JsonIgnore]
        public Payment? Payment { get; set; }

        [JsonIgnore]
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
