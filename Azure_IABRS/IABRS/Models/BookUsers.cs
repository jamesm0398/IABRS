using System;
using System.Collections.Generic;

//Class: BookUsers
//Summary: This class contains the getters/setters for various attributes of a book's user, i.e. how is the book related to the user, do they own it, is it in their cart, etc

namespace IABRS.Models
{
    public partial class BookUsers
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public bool? InCart { get; set; }
        public bool? Owned { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
