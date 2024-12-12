using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DevelopmentPlanComments
    {
        public int DevelopmentPlanCommentId { get; set; }
        public int? DevelopmentPlanStrengthId { get; set; }
        public int? DevelopmentPlanWeaknessId { get; set; }
        public int? DevelopmentPlanDetailId { get; set; }
        public string Comment { get; set; }
        public bool Confidential { get; set; }
        public int CommentTypeId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual CommentTypes CommentType { get; set; }
        public virtual DevelopmentPlanDetails DevelopmentPlanDetail { get; set; }
        public virtual DevelopmentPlanStrengths DevelopmentPlanStrength { get; set; }
        public virtual DevelopmentPlanWeaknesses DevelopmentPlanWeakness { get; set; }
    }
}
