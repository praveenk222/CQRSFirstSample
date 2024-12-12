using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class AppraisalAttachments
    {
        public int ArchiveAppraisalAttachmentId { get; set; }
        public int OriginalAppraisalAttachmentId { get; set; }
        public int ArchiveAppraisalId { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public byte[] Attachment { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Appraisals ArchiveAppraisal { get; set; }
    }
}
