using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class CommunicationsLog
    {
        public int CommunicationsLogId { get; set; }
        public int AppraisalId { get; set; }
        public string Recipients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateSent { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
