using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.Models
{
    public class InstitutionUser
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public string UserId { get; set; }

        public virtual Institution Institution{ get; set; }
        public virtual User User { get; set; }
    }
}
