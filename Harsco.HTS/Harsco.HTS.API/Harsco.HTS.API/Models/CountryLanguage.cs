using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class CountryLanguage
    {
        public int CountryId { get; set; }
        public int TranslationLanguagesId { get; set; }
    }
}
