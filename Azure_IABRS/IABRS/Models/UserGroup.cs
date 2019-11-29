using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class UserGroup
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
