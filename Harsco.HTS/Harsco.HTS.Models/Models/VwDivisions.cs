using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class VwDivisions
    {
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string Abbreviation { get; set; }
        public int BusinessGroupId { get; set; }
        public string BusinessGroupName { get; set; }
    }
}
