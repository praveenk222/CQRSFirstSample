using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class TranslationLanguages
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string WelcomeText { get; set; }
        public bool? IsActive { get; set; }
    }
}
