using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DevelopmentPlanCompletion
    {
        public DevelopmentPlanCompletion()
        {
            DevelopmentPlanDetails = new HashSet<DevelopmentPlanDetails>();
        }

        public int Id { get; set; }
        public string Completion { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<DevelopmentPlanDetails> DevelopmentPlanDetails { get; set; }
    }
}
