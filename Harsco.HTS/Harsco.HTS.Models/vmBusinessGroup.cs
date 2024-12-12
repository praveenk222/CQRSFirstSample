using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
   public class vmBusinessGroup:vmProfileBase
    {
        public int BusinessGroupID { get; set; }

        public string BusinessGroupADCode { get; set; }

        public string BusinessGroupName { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}
