using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class HrpermissionsNew
    {
        public int HrpermissionsId { get; set; }
        public int HruserId { get; set; }
        public int? BusinessGroupId { get; set; }
        public string CountryId { get; set; }

        public bool? HRBP { get;set; }
    }
}
