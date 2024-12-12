using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ExcludeFromHr
    {
        public int Id { get; set; }
        public bool Eltflag { get; set; }
        public string Adname { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
