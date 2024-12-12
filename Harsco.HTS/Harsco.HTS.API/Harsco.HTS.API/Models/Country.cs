using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Country
    {
        public Country()
        {
            Locations = new HashSet<Locations>();
        }

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

        public virtual ICollection<Locations> Locations { get; set; }
    }
}
