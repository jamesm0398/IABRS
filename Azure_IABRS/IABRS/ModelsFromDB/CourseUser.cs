using System;
using System.Collections.Generic;

namespace IABRS.ModelsFromDB
{
    public partial class CourseUser
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
