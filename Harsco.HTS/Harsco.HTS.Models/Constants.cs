using System;
using System.Collections.Generic;
using System.Text;

namespace Harsco.HTS.Models
{
    public static class MsalScopes
    {
        public static string AllFeaturesAccess { get; set; } = "AllFeaturesAccess";
    }

    public enum AccessLevels
    {
        Global = 1,
        Reigion = 5,
        Country = 10,
        Site = 15,
        UserSpecific = 20
    }
}
