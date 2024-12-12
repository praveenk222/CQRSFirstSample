using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class DevelopmentPlanDetails
    {
        public DevelopmentPlanDetails()
        {
            DevelopmentPlanApprovals = new HashSet<DevelopmentPlanApprovals>();
            DevelopmentPlanComments = new HashSet<DevelopmentPlanComments>();
        }

        public int ArchiveDevelopmentPlanDetailId { get; set; }
        public int OriginalDevelopmentPlanDetailId { get; set; }
        public int ArchiveDevelopmentPlanId { get; set; }
        public string Category { get; set; }
        public string Objective { get; set; }
        public string Activity { get; set; }
        public string SupportRequired { get; set; }
        public DateTime DateDue { get; set; }
        public string MeasurementProcess { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int? PointOfEntryId { get; set; }
        public int? ActivityLoopId { get; set; }
        public int? DevelopmentLoopId { get; set; }

        public virtual DevelopmentPlans ArchiveDevelopmentPlan { get; set; }
        public virtual ICollection<DevelopmentPlanApprovals> DevelopmentPlanApprovals { get; set; }
        public virtual ICollection<DevelopmentPlanComments> DevelopmentPlanComments { get; set; }
    }
}
