using System;
using System.Collections.Generic;

namespace IABRS.ModelsFromDB
{
    public partial class Group
    {
        public Group()
        {
            GroupPermission = new HashSet<GroupPermission>();
            UserGroup = new HashSet<UserGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupPermission> GroupPermission { get; set; }
        public virtual ICollection<UserGroup> UserGroup { get; set; }
    }
}
