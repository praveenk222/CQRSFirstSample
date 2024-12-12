using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class EducationalDegrees
    {
        public EducationalDegrees()
        {
            EducationalInstitutions = new HashSet<EducationalInstitutions>();
        }

        public int EducationalDegreeId { get; set; }
        public string Abbreviation { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<EducationalInstitutions> EducationalInstitutions { get; set; }
    }
}
