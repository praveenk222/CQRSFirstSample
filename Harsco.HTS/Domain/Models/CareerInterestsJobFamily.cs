using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class CareerInterestsJobFamily
    {
        public int Id { get; set; }
        public string JobFamily { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
