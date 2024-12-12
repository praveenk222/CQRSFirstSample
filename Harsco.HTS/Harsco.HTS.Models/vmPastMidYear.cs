using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
   public class vmPastMidYear
    {
        public int ArchiveAppraisalId { get; set; }

        public int OriginalAppraisalId { get; set; }

        public int ArchiveProfileId { get; set; }

        public int OriginalProfileId { get; set; }

        public string AppraisalType { get; set; }

        public string FromWhere { get; set; }
    }
}
