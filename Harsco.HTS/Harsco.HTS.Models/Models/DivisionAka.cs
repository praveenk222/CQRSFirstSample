using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class DivisionAka
    {
        public int DivisionAkaid { get; set; }
        public int? DivisionId { get; set; }
        public string Alias { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual BusinessUnits Division { get; set; }
    }
}
