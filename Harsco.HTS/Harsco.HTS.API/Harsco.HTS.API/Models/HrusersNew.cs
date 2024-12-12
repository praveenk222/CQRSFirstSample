using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class HrusersNew
    {
        public int HruserId { get; set; }
        public string UserName { get; set; }
        public bool? SecurityUser { get; set; }
        public bool? SuperUser { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string TempId { get; set; }
    }
}
