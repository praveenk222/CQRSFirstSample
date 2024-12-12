using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DevelopmentPlanWeaknesses
    {
        public DevelopmentPlanWeaknesses()
        {
            DevelopmentPlanApprovals = new HashSet<DevelopmentPlanApprovals>();
            DevelopmentPlanComments = new HashSet<DevelopmentPlanComments>();
        }

        public int DevelopmentPlanWeaknessId { get; set; }
        public int DevelopmentPlanId { get; set; }
        public string Weakness { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<DevelopmentPlanApprovals> DevelopmentPlanApprovals { get; set; }
        public virtual ICollection<DevelopmentPlanComments> DevelopmentPlanComments { get; set; }
    }
}
