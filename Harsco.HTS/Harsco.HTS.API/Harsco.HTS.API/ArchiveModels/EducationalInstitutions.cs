using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class EducationalInstitutions
    {
        public int ArchiveEducationalInstitutionId { get; set; }
        public int OriginalEducationalInstitutionId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string InstitutionName { get; set; }
        public string Address { get; set; }
        public string EducationalDegree { get; set; }
        public string DegreeObtainedOther { get; set; }
        public int YearsAttendedStart { get; set; }
        public int? YearsAttendedEnd { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
    }
}
