using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class TrainingDevelopment
    {
        public int ArchiveTrainingDevelopmentId { get; set; }
        public int OriginalTrainingDevelopmentId { get; set; }
        public int ArchiveProfileId { get; set; }
        public string Description { get; set; }
        public string TrainingCategory { get; set; }
        public string CertificationNumber { get; set; }
        public int? YearObtained { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles ArchiveProfile { get; set; }
    }
}
