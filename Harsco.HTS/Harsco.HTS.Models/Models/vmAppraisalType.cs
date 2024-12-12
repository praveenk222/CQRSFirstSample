using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Models
{
    public class vmAppraisalType
    {
        public int AppraisalTypeId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
