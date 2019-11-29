using IABRS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.Utilities
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        public ValidEmailDomainAttribute(string allowedDomain)
        {
            AllowedDomain = allowedDomain;
            testsForNADContext context = new testsForNADContext();
            System.Linq.IQueryable<string> instDomains = context.Institution.Select(n => n.Domain);
            AllowedDomains = new List<string>();
            foreach (string dom in instDomains)
            {
                AllowedDomains.Add(dom.ToUpper());
            }
        }

        public string AllowedDomain { get; }
        public List<string> AllowedDomains{ get; }

        public override bool IsValid(object value)
        {
            string[] inDomain = value.ToString().Split("@");

            return AllowedDomains.Contains(inDomain[1].ToUpper());
            
        }
    }
}
