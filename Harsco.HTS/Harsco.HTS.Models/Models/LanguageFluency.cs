using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class LanguageFluency
    {
        public LanguageFluency()
        {
            UnderstoodLanguages = new HashSet<UnderstoodLanguages>();
        }

        public int LanguageFluencyId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<UnderstoodLanguages> UnderstoodLanguages { get; set; }
    }
}
