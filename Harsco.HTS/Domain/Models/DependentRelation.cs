using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class DependentRelation
{
    public int DependentId { get; set; }

    public string PatientId { get; set; } = null!;

    public int RelationId { get; set; }

    public string RelationshipCode { get; set; } = null!;

    public string? ContactNumber { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
