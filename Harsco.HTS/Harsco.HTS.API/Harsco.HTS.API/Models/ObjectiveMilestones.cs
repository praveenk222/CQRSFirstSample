using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ObjectiveMilestones
    {
        public ObjectiveMilestones()
        {
            ObjectiveApprovals = new HashSet<ObjectiveApprovals>();
            ObjectiveComments = new HashSet<ObjectiveComments>();
        }

        public int ObjectiveMilestoneId { get; set; }
        public int ObjectiveId { get; set; }
        public string Title { get; set; }
        public DateTime DateDue { get; set; }
        public int MilestoneStatusId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual MilestoneStatus MilestoneStatus { get; set; }
        public virtual Objectives Objective { get; set; }
        public virtual ICollection<ObjectiveApprovals> ObjectiveApprovals { get; set; }
        public virtual ICollection<ObjectiveComments> ObjectiveComments { get; set; }
    }
}
