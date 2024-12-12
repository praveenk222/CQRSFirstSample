using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TblBireportLink
    {
        public int Id { get; set; }
        public string ReportText { get; set; }
        public string ReportUrl { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
