using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class DevelopmentPlans
    {
        public DevelopmentPlans()
        {
            DevelopmentPlanDetails = new HashSet<DevelopmentPlanDetails>();
            DevelopmentPlanStrengths = new HashSet<DevelopmentPlanStrengths>();
            DevelopmentPlanWeaknesses = new HashSet<DevelopmentPlanWeaknesses>();
        }

        public int ArchiveDevelopmentPlanId { get; set; }
        public int OriginalDevelopmentPlanId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals ArchiveAppraisal { get; set; }
        public virtual ICollection<DevelopmentPlanDetails> DevelopmentPlanDetails { get; set; }
        public virtual ICollection<DevelopmentPlanStrengths> DevelopmentPlanStrengths { get; set; }
        public virtual ICollection<DevelopmentPlanWeaknesses> DevelopmentPlanWeaknesses { get; set; }
    }
}
