using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ObjectiveComments
    {
        public int ObjectiveCommentId { get; set; }
        public int? ObjectiveId { get; set; }
        public int? ObjectiveMilestoneId { get; set; }
        public string Comment { get; set; }
        public bool Confidential { get; set; }
        public int CommentTypeId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual CommentTypes CommentType { get; set; }
        public virtual Objectives Objective { get; set; }
        public virtual ObjectiveMilestones ObjectiveMilestone { get; set; }
    }
}
