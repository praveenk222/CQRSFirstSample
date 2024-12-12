using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Country
    {
       
        public int CountryId { get; set; }
        public string CountryAdcode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public int TsregionId { get; set; }
        public string Continent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
