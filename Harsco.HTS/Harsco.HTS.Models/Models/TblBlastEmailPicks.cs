using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TblBlastEmailPicks
    {
        public int PickId { get; set; }
        public string PickTitle { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
