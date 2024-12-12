using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdminOrganizationHoliday
{
    public int HolidayScheduleId { get; set; }

    public int OrganizationId { get; set; }

    public string HolidayName { get; set; } = null!;

    public DateOnly HolidayDate { get; set; }

    public bool IsRecurring { get; set; }

    public string HolidayType { get; set; } = null!;

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual AdminOrganization Organization { get; set; } = null!;
}
