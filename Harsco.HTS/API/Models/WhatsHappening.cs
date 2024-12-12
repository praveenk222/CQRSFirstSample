using System;
using System.Collections.Generic;

namespace API.Models;

public partial class WhatsHappening
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public string? Url { get; set; }

    public string Category { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int? OrganizationId { get; set; }

    public virtual AdminOrganization? Organization { get; set; }
}
