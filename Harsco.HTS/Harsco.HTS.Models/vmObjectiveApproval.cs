using System;

namespace Harsco.HTS.ViewModels
{
    public class vmObjectiveApproval
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
    }
}