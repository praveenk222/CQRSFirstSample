using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Institutions
    {
        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
