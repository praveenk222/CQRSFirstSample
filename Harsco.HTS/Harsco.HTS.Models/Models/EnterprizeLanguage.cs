using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class EnterprizeLanguage
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageValue { get; set; }
        public string Browser { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
