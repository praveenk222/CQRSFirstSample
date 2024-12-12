using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DevelopmentPlans
    {
        public DevelopmentPlans()
        {
            DevelopmentPlanDetails = new HashSet<DevelopmentPlanDetails>();
            DevelopmentPlanStrengths = new HashSet<DevelopmentPlanStrengths>();
        }

        public int DevelopmentPlanId { get; set; }
        public int AppraisalId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual Appraisals Appraisal { get; set; }
        public virtual ICollection<DevelopmentPlanDetails> DevelopmentPlanDetails { get; set; }
        public virtual ICollection<DevelopmentPlanStrengths> DevelopmentPlanStrengths { get; set; }
    }
}
