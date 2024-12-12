using System;
using System.Collections.Generic;

namespace Harsco.HTS.API.Models
{
    public partial class ToolTips
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TranslationLanguagesId { get; set; }
        public string ToolTip { get; set; }
    }
}
