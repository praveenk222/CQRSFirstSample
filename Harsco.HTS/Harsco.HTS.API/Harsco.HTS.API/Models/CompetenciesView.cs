using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CompetenciesView
    {
        public int CompetencyId { get; set; }
        public int AppraisalId { get; set; }
        public int EnterpriseCompetencyId { get; set; }
        public int? EmployeeSkillRatingId { get; set; }
        public int? ManagerSkillRatingId { get; set; }
        public string Comment { get; set; }
        public string ManagerComment { get; set; }
        public string Title { get; set; }
        public int? CompetencyCommentId { get; set; }
    }
}
