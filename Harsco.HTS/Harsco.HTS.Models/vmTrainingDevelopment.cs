using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmTrainingDevelopment :  vmProfileBase
    {
        public int TrainingDevelopmentId { get; set; }
        public int ProfileId { get; set; }
        public string Description { get; set; }
        public int TrainingCategoryId { get; set; }
        public string TrainingCategoryName { get; set; }
        public string TrainingCategoryOther { get; set; }
        public string CertificationNumber { get; set; }
        public int? YearObtained { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        

    }
}
