using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ReportMaster
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public bool? IsDeleted { get; set; }
        public string ProcedureName { get; set; }
    }
}
