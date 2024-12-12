using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class WorkExperienceDetails
    {
        public int WorkExperienceDetailId { get; set; }
        public int WorkExperienceId { get; set; }
        public string Title { get; set; }
        public string Responsibilities { get; set; }
        public int Sequence { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual WorkExperiences WorkExperience { get; set; }
    }
}
