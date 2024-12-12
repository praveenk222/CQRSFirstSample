using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
   public class vmJobFamily:vmProfileBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
