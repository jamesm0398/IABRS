﻿using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class Book
    {
        public Book()
        {
            BookCourse = new HashSet<BookCourse>();
            BookUsers = new HashSet<BookUsers>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public virtual ICollection<BookCourse> BookCourse { get; set; }
        public virtual ICollection<BookUsers> BookUsers { get; set; }
    }
}
