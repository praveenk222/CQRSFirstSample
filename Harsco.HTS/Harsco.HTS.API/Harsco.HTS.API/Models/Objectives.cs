using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Objectives
    {
        public Objectives()
        {
            ObjectiveApprovals = new HashSet<ObjectiveApprovals>();
            ObjectiveComments = new HashSet<ObjectiveComments>();
            ObjectiveMilestones = new HashSet<ObjectiveMilestones>();
        }

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

        public virtual ObjectiveAchieved Achieved { get; set; }
        public virtual Appraisals Appraisal { get; set; }
        public virtual ICollection<ObjectiveApprovals> ObjectiveApprovals { get; set; }
        public virtual ICollection<ObjectiveComments> ObjectiveComments { get; set; }
        public virtual ICollection<ObjectiveMilestones> ObjectiveMilestones { get; set; }
    }
}
