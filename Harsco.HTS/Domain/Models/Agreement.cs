using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class Agreement
{
    public int Id { get; set; }

    public string AgreementUniqueId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string AgreementText { get; set; } = null!;

    public string? Frequency { get; set; }

    public string Language { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
