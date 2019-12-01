using System;
using System.Collections.Generic;
//Class: Group
//Summary: This class contains the getters/setters for various attributes of a group, each user will be in a different permission group


namespace IABRS.Models
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
