using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class Language
{
    public int LanguageId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string LanguageName { get; set; } = null!;

    public string? Region { get; set; }

    public int? DoctorProfileId { get; set; }

    public virtual AdminDoctorProfile? DoctorProfile { get; set; }
}
