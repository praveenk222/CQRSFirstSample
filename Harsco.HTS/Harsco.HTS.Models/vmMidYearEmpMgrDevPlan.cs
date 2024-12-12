using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
   public class vmMidYearEmpMgrDevPlan : vmProfileBase
    {
        public int MidYearEmpMgrDevId { get; set; }
        public int ProfileId { get; set; }
        public int AppraisalTypeId { get; set; }
        public string EmpDevPlan { get; set; }
        public string MgrDevPlan { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string EmployeeName { get; set; }
        public string ManagerName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DevPlanDetailId { get; set; }
        public vmDevelopmentPlanDetails DevPlanDetails { get; set; }

    }
}
