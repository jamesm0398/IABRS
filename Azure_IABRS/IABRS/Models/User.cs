using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class User :IdentityUser
    {
        public User()
        {
            BookUsers = new HashSet<BookUsers>();
            CourseUser = new HashSet<CourseUser>();
            UserGroup = new HashSet<UserGroup>();
        }

        public string UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<BookUsers> BookUsers { get; set; }
        public virtual ICollection<CourseUser> CourseUser { get; set; }
        public virtual ICollection<UserGroup> UserGroup { get; set; }
    }
}
