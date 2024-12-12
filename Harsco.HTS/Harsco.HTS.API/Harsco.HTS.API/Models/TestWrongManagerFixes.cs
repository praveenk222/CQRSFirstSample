using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TestWrongManagerFixes
    {
        public int ProfileId { get; set; }
        public string EmployeeName { get; set; }
        public int? ManagerId { get; set; }
        public string Manager { get; set; }
        public int ActualMangerProfileId { get; set; }
        public string ActualManger { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
