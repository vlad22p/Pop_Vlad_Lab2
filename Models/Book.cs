using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Pop_Vlad_Lab2.Models
{
    public class Book
    {   
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "The book title is required.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "The maximum length for the title is 150 characters, and the minimum length is 5 characters")]
        public string Title { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        [Display(Name = "Category")]
        public ICollection<Borrowing>? Borrowings { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
