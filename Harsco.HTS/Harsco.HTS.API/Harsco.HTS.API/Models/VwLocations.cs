using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class VwLocations
    {
        public int LocationId { get; set; }
        public int DivisionId { get; set; }
        public int CountryId { get; set; }
        public int? ParentLocationId { get; set; }
        public string LocationName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PoliticalRegion { get; set; }
        public string PostalCode { get; set; }
    }
}
