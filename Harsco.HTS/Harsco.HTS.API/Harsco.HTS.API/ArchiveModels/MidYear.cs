using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class MidYear
    {
        public int ArchiveMidYear { get; set; }
        public int OriginalMidYearId { get; set; }
        public int ArchivedProfileId { get; set; }
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
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
