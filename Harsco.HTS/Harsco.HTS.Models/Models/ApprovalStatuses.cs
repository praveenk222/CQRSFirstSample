using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ApprovalStatuses
    {
        public ApprovalStatuses()
        {
            AppraisalApprovals = new HashSet<AppraisalApprovals>();
            CareerInterestApprovals = new HashSet<CareerInterestApprovals>();
            CompetencyApprovals = new HashSet<CompetencyApprovals>();
            DevelopmentPlanApprovals = new HashSet<DevelopmentPlanApprovals>();
            ObjectiveApprovals = new HashSet<ObjectiveApprovals>();
        }

        public int ApprovalStatusId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<AppraisalApprovals> AppraisalApprovals { get; set; }
        public virtual ICollection<CareerInterestApprovals> CareerInterestApprovals { get; set; }
        public virtual ICollection<CompetencyApprovals> CompetencyApprovals { get; set; }
        public virtual ICollection<DevelopmentPlanApprovals> DevelopmentPlanApprovals { get; set; }
        public virtual ICollection<ObjectiveApprovals> ObjectiveApprovals { get; set; }
    }
}
