using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class HumanResource
    {
        public int ArchiveId { get; set; }
        public int OriginalId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public DateTime SendToHr { get; set; }
        public DateTime SendToManager { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
