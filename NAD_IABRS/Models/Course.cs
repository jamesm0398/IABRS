using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NAD_IABRS.Models
{
    public class YCourse
    {
      [key]
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string startDate { get; set; }
        [Required, MaxLength(10)]
        public string endDate { get; set; }

        public ICollection<BookCourse> bookCourses { get; set; }

        public ICollection<CourseUser> courseUsers { get; set; }
    }
}