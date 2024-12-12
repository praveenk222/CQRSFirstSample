using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TrainingCategories
    {
        public TrainingCategories()
        {
            TrainingDevelopment = new HashSet<TrainingDevelopment>();
        }

        public int TrainingCategoryId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<TrainingDevelopment> TrainingDevelopment { get; set; }
    }
}
