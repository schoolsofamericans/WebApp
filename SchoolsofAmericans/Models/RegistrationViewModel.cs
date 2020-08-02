using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolsofAmericans.Models
{
    public class RegistrationViewModel
    {
        public string SchoolName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string LicenseStatus { get; set; }
        public BranchType BranchType { get; set; }

    }
}
