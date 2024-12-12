using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public partial class PastAppraisals
    {
        [Key]
        public int ArchiveAppraisalId { get; set; }

        public int OriginalAppraisalId { get; set; }

        public int ArchiveProfileId { get; set; }

        public int OriginalProfileId { get; set; }

        public string AppraisalType { get; set; }

        public string FromWhere { get; set; }

    }
}
