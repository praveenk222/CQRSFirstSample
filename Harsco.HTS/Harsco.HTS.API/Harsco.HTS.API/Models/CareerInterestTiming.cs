using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CareerInterestTiming
    {
        public CareerInterestTiming()
        {
            CareerInterests = new HashSet<CareerInterests>();
        }

        public int CareerInterestTimingId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<CareerInterests> CareerInterests { get; set; }
    }
}
