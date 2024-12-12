using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class AppraisalTypes
    {
        public AppraisalTypes()
        {
            Appraisals = new HashSet<Appraisals>();
            MidYear = new HashSet<MidYear>();
            MidYearEmpMgrValues = new HashSet<MidYearEmpMgrValues>();
        }

        public int AppraisalTypeId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<Appraisals> Appraisals { get; set; }
        public virtual ICollection<MidYear> MidYear { get; set; }
        public virtual ICollection<MidYearEmpMgrValues> MidYearEmpMgrValues { get; set; }
    }
}
