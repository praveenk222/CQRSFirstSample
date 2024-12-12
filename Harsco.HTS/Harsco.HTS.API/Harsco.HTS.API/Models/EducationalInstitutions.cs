using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class EducationalInstitutions
    {
        public int EducationalInstitutionId { get; set; }
        public int ProfileId { get; set; }
        public string InstitutionName { get; set; }
        public string Address { get; set; }
        public int EducationalDegreeId { get; set; }
        public string DegreeObtainedOther { get; set; }
        public int YearsAttendedStart { get; set; }
        public int? YearsAttendedEnd { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual EducationalDegrees EducationalDegree { get; set; }
        public virtual Profiles Profile { get; set; }
    }
}
