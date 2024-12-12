using System;
using System.Collections.Generic;

namespace Harsco.HTS.ViewModels
{
    public class vmDevelopmentPlan : vmProfileBase
    {
        public int DevelopmentPlanId { get; set; }
        public int AppraisalId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }        
        public List<vmDevelopmentPlanDetails> DevelopmentPlanDetails { get; set; }
    }
}