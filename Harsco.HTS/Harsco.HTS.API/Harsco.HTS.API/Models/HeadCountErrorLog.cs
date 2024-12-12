using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class HeadCountErrorLog
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string ErrorDescription { get; set; }
    }
}
