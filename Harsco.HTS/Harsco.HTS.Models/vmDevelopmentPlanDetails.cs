using System;

namespace Harsco.HTS.ViewModels
{
    public class vmDevelopmentPlanDetails 
    {
        public int DevelopmentPlanDetailId { get; set; }
        public int DevelopmentPlanId { get; set; }
        public int? Category { get; set; }
        public string Objective { get; set; }
        public string Activity { get; set; }
        public string SupportRequired { get; set; }
        public DateTime DateDue { get; set; }
        public string MeasurementProcess { get; set; }
        public int? CompletionId { get; set; }
        public int? PointOfEntryId { get; set; }
        public int? ActivityLoopId { get; set; }
        public int? DevelopmentLoopId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Result { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public vmProfile ObjectiveOwnerProfile { get; set; }
        public vmDevelopmentPlanApprovals DevelopmentPlanApproval { get; set; }
    }
}