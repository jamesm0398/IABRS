using System;
using System.Collections.Generic;

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
