using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Hrusers
    {
        public Hrusers()
        {
            Hrpermissions = new HashSet<Hrpermissions>();
        }

        public int HruserId { get; set; }
        public string UserName { get; set; }
        public bool? SecurityUser { get; set; }
        public bool? SuperUser { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<Hrpermissions> Hrpermissions { get; set; }
    }
}
