using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.ViewModels
{
    public class CreateInstitutionViewModel
    {
        [Required]
        public string InstituteName { get; set; }

        [Required]
        public string InstituteDomain { get; set; }
    }
}
