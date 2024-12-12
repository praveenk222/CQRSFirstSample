using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TestTermiatedateFixes
    {
        public int ProfileId { get; set; }
        public string NetworkId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? ActualTerminationDate { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
