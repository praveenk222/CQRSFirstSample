using System;

namespace Harsco.HTS.ViewModels
{
    public class vmAppraisals : vmProfileBase
    {
        public int AppraisalId { get; set; }
        public int AppraisalTypeId { get; set; }
        public string Cocviolation { get; set; }
        public string ManagerMeeting { get; set; }
        public string PerformanceRating { get; set; }
        public string CompetencyRating { get; set; }
        public string OverallRating { get; set; }
        public DateTime? ReviewDate { get; set; }
        public bool SelfAssessmentComplete { get; set; }
        public bool ManagerStepComplete { get; set; }
        public string EmployeeComment { get; set; }
        public string ManagerComment { get; set; }
        public string ObjectiveComment { get; set; }
        public string CompetencyComment { get; set; }
        public string SkillComment { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? EmployeeSignDate { get; set; }
        public string ManagerName { get; set; }
        public DateTime? ManagerSignDate { get; set; }
        public string ManagersManagerName { get; set; }
        public DateTime? ManagersManagerSignDate { get; set; }
        public bool? SendToHrFlag { get; set; }
        public bool HRStepComplete{ get; set; }
        public string HRComment { get; set; }
        public string ReviewedByHR { get; set; }
        public string ReviewedByHROn { get; set; }
        
    }
}