using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class DevelopmentPlanComments
    {
        public int ArchiveDevelopmentPlanCommentId { get; set; }
        public int OriginalDevelopmentPlanCommentId { get; set; }
        public int? ArchiveDevelopmentPlanStrengthId { get; set; }
        public int? ArchiveDevelopmentPlanWeaknessId { get; set; }
        public int? ArchiveDevelopmentPlanDetailId { get; set; }
        public string Comment { get; set; }
        public bool Confidential { get; set; }
        public string CommentType { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual DevelopmentPlanDetails ArchiveDevelopmentPlanDetail { get; set; }
        public virtual DevelopmentPlanStrengths ArchiveDevelopmentPlanStrength { get; set; }
        public virtual DevelopmentPlanWeaknesses ArchiveDevelopmentPlanWeakness { get; set; }
    }
}
