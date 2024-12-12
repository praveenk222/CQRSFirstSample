using System;

namespace Harsco.HTS.ViewModels
{
    public class vmMidYearEmpMgrValues : vmProfileBase
    {
        public int MidYearEmpValuesId { get; set; }
        public int ProfileId { get; set; }
        public int AppraisalTypeId { get; set; }
        public int EnterpriseCompetencyId { get; set; }
        public string EmpValueBehavior { get; set; }
        public string MgrValueBehavior { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string EmployeeName { get; set; }
        public string ManagerName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}