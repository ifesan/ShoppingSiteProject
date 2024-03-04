using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace ShoppingSite.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Navigation property for orders
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}
