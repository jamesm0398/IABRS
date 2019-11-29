using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class BookCourse
    {
        public int BookId { get; set; }
        public int CourseId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Course Course { get; set; }
    }
}
