using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class Translations
    {
        public int Id { get; set; }
        public string KeyPhrase { get; set; }
        public int TranslationLanguageId { get; set; }
        public string TranslatedText { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
