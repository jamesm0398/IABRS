using System;
using System.Collections.Generic;

namespace IABRS.ModelsFromDB
{
    public partial class BookUsers
    {
        public int BookId { get; set; }
        public int UserId { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
