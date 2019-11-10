using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NAD_IABRS.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string fName { get; set; }
        [Required]
        public string lName { get; set; }

        public string mName { get; set; }        
    }

    public class ListPerson
    {
        [NotMapped]
        public List<Person> people { get; set; }
    }

    public class PersonListTable
    {
        [NotMapped]
        public int Key { get; set; }
        [NotMapped]
        public string Display { get; set; }
    }
}
