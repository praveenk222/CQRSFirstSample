using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class Skills
    {
        public Skills()
        {
            CompetencyApprovals = new HashSet<CompetencyApprovals>();
        }

        public int ArchiveSkillId { get; set; }
        public int OriginalSkillId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string EnterpriseCompetencies { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
        public virtual ICollection<CompetencyApprovals> CompetencyApprovals { get; set; }
    }
}
