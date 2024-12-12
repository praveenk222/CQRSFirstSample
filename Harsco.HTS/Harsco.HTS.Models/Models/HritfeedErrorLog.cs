using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class HritfeedErrorLog
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
