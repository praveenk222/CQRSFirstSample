using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AdminFaq
{
    public int Id { get; set; }

    public string Header { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string? Platforms { get; set; }

    public string? Users { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
