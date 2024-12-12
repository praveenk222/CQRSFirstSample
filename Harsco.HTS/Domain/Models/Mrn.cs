using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class Mrn
{
    public int Id { get; set; }

    public string Mrnnumber { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int HospitalId { get; set; }

    public string? HospitalName { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public string? RegisterMobile { get; set; }

    public string? RegisterEmail { get; set; }

    public bool? IsPrimaryMrn { get; set; }

    public virtual AdminOrganization Hospital { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
