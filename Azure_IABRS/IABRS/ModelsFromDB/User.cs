using System;
using System.Collections.Generic;

namespace IABRS.ModelsFromDB
{
    public partial class User
    {
        public User()
        {
            BookUsers = new HashSet<BookUsers>();
            CourseUser = new HashSet<CourseUser>();
            UserGroup = new HashSet<UserGroup>();
        }

        public int UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<BookUsers> BookUsers { get; set; }
        public virtual ICollection<CourseUser> CourseUser { get; set; }
        public virtual ICollection<UserGroup> UserGroup { get; set; }
    }
}
