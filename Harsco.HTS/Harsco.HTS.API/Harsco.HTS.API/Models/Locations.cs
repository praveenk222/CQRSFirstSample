using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Locations
    {
        public int LocationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int BusinessGroupId { get; set; }
        public int CountryId { get; set; }
        public int? ParentLocationId { get; set; }
        public string LocationAdcode { get; set; }
        public string LocationName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PoliticalRegion { get; set; }
        public string PostalCode { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual BusinessGroups BusinessGroup { get; set; }
        public virtual BusinessUnits BusinessUnit { get; set; }
        public virtual Country Country { get; set; }
    }
}
