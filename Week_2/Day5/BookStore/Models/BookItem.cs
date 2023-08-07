using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookItem
    {
        [Key]
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

    }
}
