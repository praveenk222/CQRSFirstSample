using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class MilestoneStatus
    {
        public MilestoneStatus()
        {
            ObjectiveMilestones = new HashSet<ObjectiveMilestones>();
        }

        public int MilestoneStatusId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<ObjectiveMilestones> ObjectiveMilestones { get; set; }
    }
}
