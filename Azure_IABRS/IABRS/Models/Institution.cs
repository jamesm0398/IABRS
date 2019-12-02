using System;
using System.Collections.Generic;

//Class: Institution
//Summary: This class contains the getters/setters for various attributes of an institution

namespace IABRS.Models
{
    public partial class Institution
    {
        public Institution()
        {
            Course = new HashSet<Course>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }

        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
