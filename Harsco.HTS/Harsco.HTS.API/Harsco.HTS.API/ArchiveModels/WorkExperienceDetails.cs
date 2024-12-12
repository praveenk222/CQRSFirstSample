using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class WorkExperienceDetails
    {
        public int ArchiveWorkExperienceDetailId { get; set; }
        public int OriginalWorkExperienceDetailId { get; set; }
        public int ArchiveWorkExperienceId { get; set; }
        public string Title { get; set; }
        public string Responsibilities { get; set; }
        public int Sequence { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual WorkExperiences ArchiveWorkExperience { get; set; }
    }
}
