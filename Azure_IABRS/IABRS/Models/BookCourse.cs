using System;
using System.Collections.Generic;

//Class: Book
//Summary: This class contains the getters/setters for various attributes of a book's course, i.e. which course the book is for

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
