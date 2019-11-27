using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NAD_IABRS.Models
{
    public class Author
    {
        [key]
        public int authorId { get; set; }

        [Required]
        public Person person { get; set; }

        public SelectList PersonList { get; set; }

        public string bio { get; set; }

    }
}
