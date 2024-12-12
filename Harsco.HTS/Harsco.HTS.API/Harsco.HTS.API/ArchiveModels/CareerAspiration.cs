using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class CareerAspiration
    {
        public int ArchiveCareerAspirationId { get; set; }
        public int OriginalCareerAspirationId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string Aspiration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
