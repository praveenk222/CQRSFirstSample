using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TestNextWrongappraisalFixes
    {
        public int AppraisalId { get; set; }
        public string NetworkId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string CountryName { get; set; }
        public string DivisionName { get; set; }
        public string Title { get; set; }
        public int AppraisalTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
