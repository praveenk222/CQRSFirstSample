using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class CountryLanguage
    {
        public int CountryId { get; set; }
        public int TranslationLanguagesId { get; set; }
    }
}
