using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CareerAspiration
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string Aspiration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Profiles Profile { get; set; }
    }
}
