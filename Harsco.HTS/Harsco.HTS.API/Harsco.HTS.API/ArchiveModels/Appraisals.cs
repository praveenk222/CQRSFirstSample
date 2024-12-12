using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class Appraisals
    {
        public Appraisals()
        {
            AppraisalApprovals = new HashSet<AppraisalApprovals>();
            AppraisalAttachments = new HashSet<AppraisalAttachments>();
            Competencies = new HashSet<Competencies>();
            DevelopmentPlans = new HashSet<DevelopmentPlans>();
            Objectives = new HashSet<Objectives>();
            Profiles = new HashSet<Profiles>();
        }

        public int ArchiveAppraisalId { get; set; }
        public int OriginalAppraisalId { get; set; }
        public int AppraisalYear { get; set; }
        public string AppraisalType { get; set; }
        public string Cocviolation { get; set; }
        public string ManagerMeeting { get; set; }
        public string PerformanceRating { get; set; }
        public string CompetencyRating { get; set; }
        public string OverallRating { get; set; }
        public DateTime? ReviewDate { get; set; }
        public bool? SelfAssessmentComplete { get; set; }
        public bool? ManagerStepComplete { get; set; }
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
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AppraisalApprovals> AppraisalApprovals { get; set; }
        public virtual ICollection<AppraisalAttachments> AppraisalAttachments { get; set; }
        public virtual ICollection<Competencies> Competencies { get; set; }
        public virtual ICollection<DevelopmentPlans> DevelopmentPlans { get; set; }
        public virtual ICollection<Objectives> Objectives { get; set; }
        public virtual ICollection<Profiles> Profiles { get; set; }
    }
}
