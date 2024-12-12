using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class BusinessUnits
    {
        public BusinessUnits()
        {
            DivisionAka = new HashSet<DivisionAka>();
            Locations = new HashSet<Locations>();
        }

        public int BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public string Abbreviation { get; set; }
        public string DisplayName { get; set; }
        public int BusinessGroupId { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual BusinessGroups BusinessGroup { get; set; }
        public virtual ICollection<DivisionAka> DivisionAka { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
