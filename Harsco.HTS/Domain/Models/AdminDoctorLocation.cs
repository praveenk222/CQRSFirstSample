using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminDoctorLocation
{
    public int DoctorLocationId { get; set; }

    public int DoctorProfileId { get; set; }

    public int LocationId { get; set; }

    public string? Role { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual AdminDoctorProfile DoctorProfile { get; set; } = null!;

    public virtual AdminUser? LastModifiedByNavigation { get; set; }

    public virtual AdminLocation Location { get; set; } = null!;
}
