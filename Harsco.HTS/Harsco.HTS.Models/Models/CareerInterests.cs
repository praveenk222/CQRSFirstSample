using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CareerInterests
    {
        public CareerInterests()
        {
            CareerInterestApprovals = new HashSet<CareerInterestApprovals>();
        }

        public int CareerInterestId { get; set; }
        public int ProfileId { get; set; }
        public string Description { get; set; }
        public int JobFamilyId { get; set; }
        public int CareerInterestTimingId { get; set; }
        public string WillingToRelocate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual CareerInterestTiming CareerInterestTiming { get; set; }
        public virtual Profiles Profile { get; set; }
        public virtual ICollection<CareerInterestApprovals> CareerInterestApprovals { get; set; }
    }
}
