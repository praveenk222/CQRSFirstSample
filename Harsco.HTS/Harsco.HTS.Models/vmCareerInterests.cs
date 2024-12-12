using System;

namespace Harsco.HTS.ViewModels
{
    public class vmCareerInterests : vmProfileBase
    {
        public int CareerInterestId { get; set; }
        public int? ProfileId { get; set; }
        public string Description { get; set; }
        public int? JobFamilyId { get; set; }
        public string JobFamilyName { get; set; }
        public int? CareerInterestTimingId { get; set; }
        public string CareerInterestTimingName { get; set; }
        public string WillingToRelocate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}