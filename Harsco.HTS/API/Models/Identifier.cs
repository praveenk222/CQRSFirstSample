using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Identifier
{
    public int IdentifierId { get; set; }

    public string PatientId { get; set; } = null!;

    public string IdentifierType { get; set; } = null!;

    public string IdentifierValue { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual PatientUser Patient { get; set; } = null!;
}
