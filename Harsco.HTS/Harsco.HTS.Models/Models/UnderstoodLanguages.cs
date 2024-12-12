using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class UnderstoodLanguages
    {
        public int UnderstoodLanguageId { get; set; }
        public int ProfileId { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int LanguageFluencyId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual LanguageFluency LanguageFluency { get; set; }
        public virtual Profiles Profile { get; set; }
    }
}
