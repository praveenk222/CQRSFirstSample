using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ObjectiveApprovals
    {
        public int ObjectiveApprovalId { get; set; }
        public int? ObjectiveId { get; set; }
        public int? ObjectiveMilestoneId { get; set; }
        public int ApprovalStatusId { get; set; }
        public string Comment { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ApprovalStatuses ApprovalStatus { get; set; }
        public virtual Objectives Objective { get; set; }
        public virtual ObjectiveMilestones ObjectiveMilestone { get; set; }
    }
}
