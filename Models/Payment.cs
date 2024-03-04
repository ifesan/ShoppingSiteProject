using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace ShoppingSite.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }

        // Navigation property
        [JsonIgnore]
        public Order? Order { get; set; }
    }
}
