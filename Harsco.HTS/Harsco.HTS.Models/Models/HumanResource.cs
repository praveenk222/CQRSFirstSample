using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class HumanResource
    {
        public int Id { get; set; }
        public int AppraisalId { get; set; }
        public DateTime? SendToHr { get; set; }
        public DateTime? SendToManager { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals Appraisal { get; set; }
    }
}
