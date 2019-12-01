using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

//Class: User
//Summary: This class contains the getters/setters for various attributes of a user, such as their name, username and password, as well as what books they have, what courses they are in and their user group

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
