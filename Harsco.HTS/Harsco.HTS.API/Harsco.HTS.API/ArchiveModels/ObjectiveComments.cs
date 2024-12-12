using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class ObjectiveComments
    {
        public int ArchiveObjectiveCommentId { get; set; }
        public int OriginalObjectiveCommentId { get; set; }
        public int? ArchiveObjectiveId { get; set; }
        public int? ArchiveObjectiveMilestoneId { get; set; }
        public string Comment { get; set; }
        public bool Confidential { get; set; }
        public string CommentType { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Objectives ArchiveObjective { get; set; }
        public virtual ObjectiveMilestones ArchiveObjectiveMilestone { get; set; }
    }
}
