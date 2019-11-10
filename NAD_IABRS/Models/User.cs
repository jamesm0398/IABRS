using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NAD_IABRS.Models
{
    public class User
    {
        [key]
        public int userId { get; set; }

        [Required]
        public Person person { get; set; }

        [Required]
        UInt32 permissions { get; set; }

       
        public virtual List<CourseUser> courseUsers { get; set; }

      
        public virtual List<BookUser> bookUsers { get; set; }
    }
}
