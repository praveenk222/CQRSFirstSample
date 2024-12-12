using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminImageMaintenance
{
    public int Id { get; set; }

    public string ScreenType { get; set; } = null!;

    public string? Header { get; set; }

    public bool Status { get; set; }

    public string ImageType { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public bool IsActive { get; set; }
}
