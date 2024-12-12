﻿using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class MidYearEmpValuesDevmtPlan
    {
        public int MidYearEmpValuesDevmtPlanId { get; set; }
        public int ProfileId { get; set; }
        public int AppraisalTypeId { get; set; }
        public string EmpValueBehavior { get; set; }
        public string MgrValueBehavior { get; set; }
        public string EmpDevelopmentPlan { get; set; }
        public string MgrDevelopmentPlan { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string EmployeeName { get; set; }
        public string ManagerName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AppraisalTypes AppraisalType { get; set; }
        public virtual Profiles Profile { get; set; }
    }
}