using System.ComponentModel.DataAnnotations;

namespace Pop_Vlad_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
