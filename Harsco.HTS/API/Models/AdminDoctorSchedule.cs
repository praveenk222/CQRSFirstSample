using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AdminDoctorSchedule
{
    public int ScheduleId { get; set; }

    public int DoctorProfileId { get; set; }

    public string? Identifier { get; set; }

    public bool Active { get; set; }

    public string? ServiceCategory { get; set; }

    public string? ServiceType { get; set; }

    public string? Specialty { get; set; }

    public string Actor { get; set; } = null!;

    public DateTime? PlanningHorizonStart { get; set; }

    public DateTime? PlanningHorizonEnd { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateOnly AvailableDate { get; set; }

    public virtual AdminDoctorProfile DoctorProfile { get; set; } = null!;

    public virtual ICollection<ScheduleException> ScheduleExceptions { get; set; } = new List<ScheduleException>();
}
