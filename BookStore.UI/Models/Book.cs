using System.ComponentModel.DataAnnotations;

namespace BookStore.UI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public double? Price { get; set; }
        [Required]
        public int? AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}