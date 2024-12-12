using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmEndYearCompetencies:vmProfileBase
    {
        public int CompetencyId { get; set; }
        public int AppraisalId { get; set; }
        public int EnterpriseCompetencyId { get; set; }
        public int? EmployeeSkillRatingId { get; set; }
        public int? ManagerSkillRatingId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string EmployeeComment { get; set; }
        public string ManagerComment{ get; set; }
    }
}
