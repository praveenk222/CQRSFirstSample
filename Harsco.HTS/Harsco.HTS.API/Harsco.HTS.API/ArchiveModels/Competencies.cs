using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class Competencies
    {
        public Competencies()
        {
            CompetencyApprovals = new HashSet<CompetencyApprovals>();
        }

        public int ArchiveCompetencyId { get; set; }
        public int OriginalCompetencyId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public string EnterpriseCompetency { get; set; }
        public string EmployeeSkillRating { get; set; }
        public string ManagerSkillRating { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals ArchiveAppraisal { get; set; }
        public virtual ICollection<CompetencyApprovals> CompetencyApprovals { get; set; }
    }
}
