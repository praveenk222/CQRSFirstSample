using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class DevelopmentPlanApprovals
    {
        public int ArchiveDevelopmentPlanApprovalId { get; set; }
        public int OriginalDevelopmentPlanApprovalId { get; set; }
        public int? ArchiveDevelopmentPlanStrengthId { get; set; }
        public int? ArchiveDevelopmentPlanWeaknessId { get; set; }
        public int? ArchiveDevelopmentPlanDetailId { get; set; }
        public string Comment { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual DevelopmentPlanDetails ArchiveDevelopmentPlanDetail { get; set; }
        public virtual DevelopmentPlanStrengths ArchiveDevelopmentPlanStrength { get; set; }
        public virtual DevelopmentPlanWeaknesses ArchiveDevelopmentPlanWeakness { get; set; }
    }
}
