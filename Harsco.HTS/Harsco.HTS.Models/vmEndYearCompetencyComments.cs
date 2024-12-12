using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmEndYearCompetencyComments
    {
        public int CompetencyCommentId { get; set; }
        public int CompetencyId { get; set; }
        public string Comment { get; set; }
        public string ManagerComment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
