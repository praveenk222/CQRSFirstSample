using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class AppraisalApprovals
    {
        public int ArchiveAppraisalApprovalId { get; set; }
        public int OriginalAppraisalApprovalId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public string Comment { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals ArchiveAppraisal { get; set; }
    }
}
