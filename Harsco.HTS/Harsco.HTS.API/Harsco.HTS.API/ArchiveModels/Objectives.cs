using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class Objectives
    {
        public Objectives()
        {
            ObjectiveApprovals = new HashSet<ObjectiveApprovals>();
            ObjectiveComments = new HashSet<ObjectiveComments>();
            ObjectiveMilestones = new HashSet<ObjectiveMilestones>();
        }

        public int ArchiveObjectiveId { get; set; }
        public int OriginalObjectiveId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public string Description { get; set; }
        public string YearEndResults { get; set; }
        public string ManagerYearEndResults { get; set; }
        public DateTime DateDue { get; set; }
        public string Achieved { get; set; }
        public string ManagerAchieved { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals ArchiveAppraisal { get; set; }
        public virtual ICollection<ObjectiveApprovals> ObjectiveApprovals { get; set; }
        public virtual ICollection<ObjectiveComments> ObjectiveComments { get; set; }
        public virtual ICollection<ObjectiveMilestones> ObjectiveMilestones { get; set; }
    }
}
