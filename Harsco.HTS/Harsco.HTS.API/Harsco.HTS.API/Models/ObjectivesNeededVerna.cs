using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ObjectivesNeededVerna
    {
        public string EmployeeName { get; set; }
        public string BusinessGroup { get; set; }
        public string BusinessUnit { get; set; }
        public string ManagerName { get; set; }
        public string ManagerManagerName { get; set; }
        public string CountryName { get; set; }
        public string JobFamilyName { get; set; }
        public DateTime DateHired { get; set; }
        public string PerformanceRating { get; set; }
        public string Vbrating { get; set; }
        public string OverallRating { get; set; }
    }
}
