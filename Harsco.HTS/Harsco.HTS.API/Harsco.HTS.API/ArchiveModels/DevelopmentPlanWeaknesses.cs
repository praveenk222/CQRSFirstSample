using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class DevelopmentPlanWeaknesses
    {
        public DevelopmentPlanWeaknesses()
        {
            DevelopmentPlanApprovals = new HashSet<DevelopmentPlanApprovals>();
            DevelopmentPlanComments = new HashSet<DevelopmentPlanComments>();
        }

        public int ArchiveDevelopmentPlanWeaknessId { get; set; }
        public int OriginalDevelopmentPlanWeaknessId { get; set; }
        public int ArchiveDevelopmentPlanId { get; set; }
        public string Weakness { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual DevelopmentPlans ArchiveDevelopmentPlan { get; set; }
        public virtual ICollection<DevelopmentPlanApprovals> DevelopmentPlanApprovals { get; set; }
        public virtual ICollection<DevelopmentPlanComments> DevelopmentPlanComments { get; set; }
    }
}
