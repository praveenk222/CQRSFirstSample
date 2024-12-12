using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class CompetencyComments
    {
        public int CompetencyCommentId { get; set; }
        public int CompetencyId { get; set; }
        public string Comment { get; set; }
        public string ManagerComment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Competencies Competency { get; set; }
    }
}
