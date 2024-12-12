using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class LanguageFluency
    {
     

        public int LanguageFluencyId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

    }
}
