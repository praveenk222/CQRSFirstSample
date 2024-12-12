using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmAwardsPatentsRecognitions: vmProfileBase
    {
        public int AwardPatentRecognitionId { get; set; }
        public int ProfileId { get; set; }
        public string Description { get; set; }
        public string DateReceived { get; set; }
        public string ReferenceNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
