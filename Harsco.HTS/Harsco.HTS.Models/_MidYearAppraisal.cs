using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Harsco.HTS.API.Models
{
    public  class _MidYearAppraisal
    {
        [Key]
        public string EmployeeName { get; set; }

        public string Address { get; set; }

        public DateTime? DateHired { get; set; }

        public string Mgr { get; set; }

        public string DivisionName { get; set; }

        public string JobTitle { get; set; }

        public string JobFamilyName { get; set; }

        public string Email { get; set; }

        public string LocationName { get; set; }

        public string Title { get; set; }

        public string EmpObjective { get; set; }

        public string EmpValueBehavior { get; set; }

        public string EmpDevelopmentPlan { get; set; }

        public DateTime? ReviewDate { get; set; }

        public DateTime? EmpSignDate { get; set; }

        public DateTime? MgrSignDate { get; set; }

        public string ManagerName { get; set; }

        public string MgrDevelopmentPlan { get; set; }

        public string MgrObjective { get; set; }

        public string MgrValueBehavior { get; set; }
    }


}
