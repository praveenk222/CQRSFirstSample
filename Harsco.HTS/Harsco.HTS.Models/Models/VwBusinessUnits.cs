using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class VwBusinessUnits
    {
        public int BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public string Abbreviation { get; set; }
        public string DisplayName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
