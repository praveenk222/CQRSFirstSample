using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.ViewModels
{
    public class vmUnderstoodLanguages : vmProfileBase
    {
        public int UnderstoodLanguageId { get; set; }
        public int ProfileId { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int LanguageFluencyId { get; set; }
        public string LanguageFluencyName { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
