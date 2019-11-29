using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class Course
    {
        public Course()
        {
            BookCourse = new HashSet<BookCourse>();
            CourseUser = new HashSet<CourseUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int InstitutionId { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual ICollection<BookCourse> BookCourse { get; set; }
        public virtual ICollection<CourseUser> CourseUser { get; set; }
    }
}
