using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class Dependent
{
    public int Id { get; set; }

    public string? Uhid { get; set; }

    public bool Active { get; set; }

    public string? DependentUhid { get; set; }

    public string? RelationshipCategory { get; set; }

    public string? Relationship { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User? DependentUh { get; set; }
}
