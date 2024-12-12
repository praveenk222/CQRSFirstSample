using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class CareerInterestApprovals
    {
        public int ArchiveCareerInterestApprovalId { get; set; }
        public int OriginalCareerInterestApprovalId { get; set; }
        public int ArchiveCareerInterestId { get; set; }
        public string ApprovalStatus { get; set; }
        public string Comment { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual CareerInterests ArchiveCareerInterest { get; set; }
    }
}
