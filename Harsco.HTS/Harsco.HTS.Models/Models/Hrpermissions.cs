using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Hrpermissions
    {
        public int HrpermissionsId { get; set; }
        public int HruserId { get; set; }
        public int? BusinessGroupId { get; set; }
        public int? CountryId { get; set; }
        public bool Hrbp { get; set; }

        public virtual Hrusers Hruser { get; set; }
    }
}
