using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class LicenseCategories
    {
        public LicenseCategories()
        {
            LicsCertsProfOrgs = new HashSet<LicsCertsProfOrgs>();
        }

        public int LicenseCategoryId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<LicsCertsProfOrgs> LicsCertsProfOrgs { get; set; }
    }
}
