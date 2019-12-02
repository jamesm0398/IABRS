using IABRS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.ViewModels
{
    public class EditInstitutionViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Domian { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
