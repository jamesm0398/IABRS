using System;
using System.Collections.Generic;

namespace IABRS.Models
{
    public partial class Institution
    {
        public Institution()
        {
            Course = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
