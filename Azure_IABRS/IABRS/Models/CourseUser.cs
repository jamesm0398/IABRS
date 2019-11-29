﻿using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class CourseUser
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string UserId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
