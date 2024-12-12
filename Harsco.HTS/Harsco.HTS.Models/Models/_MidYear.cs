﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Harsco.HTS.API.Models
{
    public class _MidYear
    {
        [Key]
        public int MidYearId { get; set; }
        public int ProfileId { get; set; }
        public int AppraisalTypeId { get; set; }
        public string EmpObjective { get; set; }
        public string MgrObjective { get; set; }
        public string EmpValueBehavior { get; set; }
        public string MgrValueBehavior { get; set; }
        public string EmpDevelopmentPlan { get; set; }
        public string MgrDevelopmentPlan { get; set; }
        public DateTime? ReviewDate { get; set; }
        public DateTime? EmpSignDate { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? MgrSignDate { get; set; }
        public string ManagerName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public int? ObjectiveId { get; set; }
    }
}