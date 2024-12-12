using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ScheduleException
{
    public int Id { get; set; }

    public int ScheduleId { get; set; }

    public string? ExceptionType { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonDescription { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? AdditionalData { get; set; }

    public virtual AdminDoctorSchedule Schedule { get; set; } = null!;
}
