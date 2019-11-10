using System.ComponentModel.DataAnnotations;

namespace NAD_IABRS.Models
{
    public class BookCourse
    {
        [key]
        public int BookId { get; set; }
        [key]
        public int CouseId { get; set; }
        [Required]
        public Book Book { get; set; }
        [Required]
        public YCourse Course { get; set; }
    }
}