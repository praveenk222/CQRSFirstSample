using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class UnderstoodLanguages
    {
        public int ArchiveUnderstoodLanguageId { get; set; }
        public int OriginalUnderstoodLanguageId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string LanguageFluency { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
    }
}
