using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CareerInterestApprovals
    {
        public int CareerInterestApprovalId { get; set; }
        public int CareerInterestId { get; set; }
        public int ApprovalStatusId { get; set; }
        public string Comment { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string ApproverName { get; set; }
        public string ApproverId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ApprovalStatuses ApprovalStatus { get; set; }
        public virtual CareerInterests CareerInterest { get; set; }
    }
}
