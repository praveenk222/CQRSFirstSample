using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class AwardsPatentsRecognitions
    {
        public int ArchiveAwardPatentRecognitionId { get; set; }
        public int OriginalAwardPatentRecognitionId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string Description { get; set; }
        public string DateReceived { get; set; }
        public string ReferenceNumber { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
    }
}
