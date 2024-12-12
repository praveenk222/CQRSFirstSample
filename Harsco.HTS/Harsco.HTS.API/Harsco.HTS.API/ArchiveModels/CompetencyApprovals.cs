using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class CompetencyApprovals
    {
        public int ArchiveCompetencyApprovalId { get; set; }
        public int OriginalCompetencyApprovalId { get; set; }
        public int? ArchiveCompetencyId { get; set; }
        public int? ArchiveSkillId { get; set; }
        public string ApprovalStatus { get; set; }
        public string Comment { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Competencies ArchiveCompetency { get; set; }
        public virtual Skills ArchiveSkill { get; set; }
    }
}
