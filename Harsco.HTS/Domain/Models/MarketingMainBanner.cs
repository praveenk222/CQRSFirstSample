using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class MarketingMainBanner
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
