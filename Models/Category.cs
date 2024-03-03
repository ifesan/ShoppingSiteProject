using System.Collections.Generic;
namespace ShoppingSite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Navigation property for products
        public ICollection<Product>? Products { get; set; }
    }
}
