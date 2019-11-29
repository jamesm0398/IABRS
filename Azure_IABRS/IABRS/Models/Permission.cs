using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class Permission
    {
        public Permission()
        {
            GroupPermission = new HashSet<GroupPermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public virtual ICollection<GroupPermission> GroupPermission { get; set; }
    }
}
