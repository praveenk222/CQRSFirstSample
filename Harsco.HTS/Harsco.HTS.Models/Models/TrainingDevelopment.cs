using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TrainingDevelopment
    {
        public int TrainingDevelopmentId { get; set; }
        public int ProfileId { get; set; }
        public string Description { get; set; }
        public int TrainingCategoryId { get; set; }
        public string TrainingCategoryOther { get; set; }
        public string CertificationNumber { get; set; }
        public int? YearObtained { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual Profiles Profile { get; set; }
        public virtual TrainingCategories TrainingCategory { get; set; }
    }
}
