using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class WorkExperiences
    {
        public WorkExperiences()
        {
            WorkExperienceDetails = new HashSet<WorkExperienceDetails>();
        }

        public int ArchiveWorkExperienceId { get; set; }
        public int OriginalWorkExperienceId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string EmployerName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public DateTime DateEmploymentStarted { get; set; }
        public DateTime? DateEmploymentEnded { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
        public virtual ICollection<WorkExperienceDetails> WorkExperienceDetails { get; set; }
    }
}
