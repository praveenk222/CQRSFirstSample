using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DevelopmentPlanApprovals
    {
        public int DevelopmentPlanApprovalId { get; set; }
        public int? DevelopmentPlanStrengthId { get; set; }
        public int? DevelopmentPlanWeaknessId { get; set; }
        public int? DevelopmentPlanDetailId { get; set; }
        public string Comment { get; set; }
        public int ApprovalStatusId { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ApprovalStatuses ApprovalStatus { get; set; }
        public virtual DevelopmentPlanDetails DevelopmentPlanDetail { get; set; }
        public virtual DevelopmentPlanStrengths DevelopmentPlanStrength { get; set; }
        public virtual DevelopmentPlanWeaknesses DevelopmentPlanWeakness { get; set; }
    }
}
