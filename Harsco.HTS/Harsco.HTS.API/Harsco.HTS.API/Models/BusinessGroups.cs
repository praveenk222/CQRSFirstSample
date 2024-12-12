using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class BusinessGroups
    {
        public BusinessGroups()
        {
            BusinessUnits = new HashSet<BusinessUnits>();
            Divisions = new HashSet<Divisions>();
            Locations = new HashSet<Locations>();
        }

        public int BusinessGroupId { get; set; }
        public string BusinessGroupAdcode { get; set; }
        public string BusinessGroupName { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<BusinessUnits> BusinessUnits { get; set; }
        public virtual ICollection<Divisions> Divisions { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
