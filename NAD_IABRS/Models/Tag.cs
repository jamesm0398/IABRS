using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NAD_IABRS.Models
{
    public class Tag
    {
        [Key]
        public int tagName { get; set; }
        [Required]
        public string description { get; set; }

       
        public ICollection<BookTag> booksTags { get; set; }
    }
}
