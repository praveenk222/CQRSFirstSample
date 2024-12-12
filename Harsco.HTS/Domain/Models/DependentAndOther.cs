using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class DependentAndOther
{
    public int DependentId { get; set; }

    public string PatientId { get; set; } = null!;

    public string RelationId { get; set; } = null!;

    public string? RelationshipCode { get; set; }

    public string? ContactNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual PatientUser Patient { get; set; } = null!;

    public virtual PatientUser Relation { get; set; } = null!;
}
