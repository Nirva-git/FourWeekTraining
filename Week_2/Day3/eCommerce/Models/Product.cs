using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
            // Foreign keys for relationships
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public Category Category { get; set; }
    }
}
