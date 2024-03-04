using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace ShoppingSite.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        // Navigation properties
        [JsonIgnore]
        public Order? Order { get; set; }
        
        [JsonIgnore]
        public Product? Product { get; set; }
    }
}
