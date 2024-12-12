using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class CompetencyComments
    {
        public int ArchiveCompetencyCommentId { get; set; }
        public int OriginalCompetencyCommentId { get; set; }
        public int ArchiveCompetencyId { get; set; }
        public string Comment { get; set; }
        public string ManagerComment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
