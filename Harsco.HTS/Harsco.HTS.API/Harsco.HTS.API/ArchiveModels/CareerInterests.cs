using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class CareerInterests
    {
        public CareerInterests()
        {
            CareerInterestApprovals = new HashSet<CareerInterestApprovals>();
        }

        public int ArchiveCareerInterestId { get; set; }
        public int OriginalCareerInterestId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string Description { get; set; }
        public string JobFamily { get; set; }
        public string CareerInterestTiming { get; set; }
        public string WillingToRelocate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
        public virtual ICollection<CareerInterestApprovals> CareerInterestApprovals { get; set; }
    }
}
