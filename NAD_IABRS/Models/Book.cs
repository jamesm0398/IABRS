using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NAD_IABRS.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int isbn { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int authorId { get; set; }
        [Required]
        public Author author { get; set; }
       
        
        public ICollection<BookTag> bookTags { get; set; }
       
        public List<BookCourse> bookCourses { get; set; }
    }
}
