using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class ObjectiveApprovals
    {
        public int ArchiveObjectiveApprovalId { get; set; }
        public int OriginalObjectiveApprovalId { get; set; }
        public int? ArchiveObjectiveId { get; set; }
        public int? ArchiveObjectiveMilestoneId { get; set; }
        public string ApprovalStatus { get; set; }
        public string Comment { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Objectives ArchiveObjective { get; set; }
        public virtual ObjectiveMilestones ArchiveObjectiveMilestone { get; set; }
    }
}
