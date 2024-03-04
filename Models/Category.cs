using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace ShoppingSite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Navigation property for products

        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}
