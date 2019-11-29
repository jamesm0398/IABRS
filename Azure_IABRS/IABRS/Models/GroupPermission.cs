using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class GroupPermission
    {
        public int GroupId { get; set; }
        public int PermissionId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
