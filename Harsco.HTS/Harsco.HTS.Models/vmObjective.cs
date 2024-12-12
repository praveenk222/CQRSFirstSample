using System;
using System.Collections.Generic;

namespace Harsco.HTS.ViewModels
{
    public class vmObjective : vmProfileBase
    {
        public int ObjectiveId { get; set; }
        public int AppraisalId { get; set; }
        public string Description { get; set; }
        public string YearEndResults { get; set; }
        public string ManagerYearEndResults { get; set; }
        public DateTime DateDue { get; set; }
        public int? AchievedId { get; set; }
        public int? ManagerAchievedId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public List<vmObjectiveApproval> ObjectiveApprovals { get; set; }
        public vmProfile ObjectiveOwnerProfile { get; set; }
        public bool IsEndYearSubmitted { get; set; }
    }

    public enum ObjectiveApprovalStatus
    {
        Submitted = 1,
        Approved = 2,
        Created = 4,
        Rejected = 3,
    }
}