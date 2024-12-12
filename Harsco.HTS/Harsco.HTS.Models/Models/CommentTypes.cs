using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CommentTypes
    {
        public CommentTypes()
        {
            DevelopmentPlanComments = new HashSet<DevelopmentPlanComments>();
            ObjectiveComments = new HashSet<ObjectiveComments>();
        }

        public int CommentTypeId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<DevelopmentPlanComments> DevelopmentPlanComments { get; set; }
        public virtual ICollection<ObjectiveComments> ObjectiveComments { get; set; }
    }
}
