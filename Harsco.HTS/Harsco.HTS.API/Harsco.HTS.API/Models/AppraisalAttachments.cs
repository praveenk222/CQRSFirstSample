using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class AppraisalAttachments
    {
        public int AppraisalAttachmentId { get; set; }
        public int AppraisalId { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public byte[] Attachment { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual Appraisals Appraisal { get; set; }
    }
}
