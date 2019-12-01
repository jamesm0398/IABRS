using System;
using System.Collections.Generic;

//Class: Permission
//Summary: This class contains the getters/setters for various attributes of a permission, each permission will have an ID and name

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
