using System;
using System.Collections.Generic;

namespace API.Models;

public partial class BannerClickReport
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public int BannerId { get; set; }

    public DateOnly ReportDate { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
