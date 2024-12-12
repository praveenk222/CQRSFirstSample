using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Competencies
    {
        public Competencies()
        {
            CompetencyApprovals = new HashSet<CompetencyApprovals>();
            CompetencyComments = new HashSet<CompetencyComments>();
        }

        public int CompetencyId { get; set; }
        public int AppraisalId { get; set; }
        public int EnterpriseCompetencyId { get; set; }
        public int? EmployeeSkillRatingId { get; set; }
        public int? ManagerSkillRatingId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual CompetencySkillRatings EmployeeSkillRating { get; set; }
        public virtual ICollection<CompetencyApprovals> CompetencyApprovals { get; set; }
        public virtual ICollection<CompetencyComments> CompetencyComments { get; set; }
    }
}
