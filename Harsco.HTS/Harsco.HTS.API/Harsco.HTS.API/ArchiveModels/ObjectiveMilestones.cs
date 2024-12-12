using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class ObjectiveMilestones
    {
        public ObjectiveMilestones()
        {
            ObjectiveApprovals = new HashSet<ObjectiveApprovals>();
            ObjectiveComments = new HashSet<ObjectiveComments>();
        }

        public int ArchiveObjectiveMilestoneId { get; set; }
        public int OriginalObjectiveMilestoneId { get; set; }
        public int ArchiveObjectiveId { get; set; }
        public string Title { get; set; }
        public DateTime DateDue { get; set; }
        public string MilestoneStatus { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Objectives ArchiveObjective { get; set; }
        public virtual ICollection<ObjectiveApprovals> ObjectiveApprovals { get; set; }
        public virtual ICollection<ObjectiveComments> ObjectiveComments { get; set; }
    }
}
