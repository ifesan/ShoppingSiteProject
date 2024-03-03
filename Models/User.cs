using System.Collections.Generic;
namespace ShoppingSite.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Navigation property for orders
        public ICollection<Order>? Orders { get; set; }
    }
}
