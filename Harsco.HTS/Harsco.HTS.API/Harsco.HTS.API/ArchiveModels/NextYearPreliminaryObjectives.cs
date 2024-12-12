using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class NextYearPreliminaryObjectives
    {
        public int ArchiveId { get; set; }
        public int OriginalId { get; set; }
        public int AppraisalId { get; set; }
        public string NextYearObjectives { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
