using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class OtpEntry
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Otp { get; set; }

    public DateTime? ExpiryTime { get; set; }

    public bool? IsUsed { get; set; }

    public DateTime? DateUsed { get; set; }

    public DateTime? CreatedBy { get; set; }

    public DateTime? UpdatedBy { get; set; }

    public int? OtpType { get; set; }

    public string? IdentificationNo { get; set; }

    public DateTime? LastFailedTime { get; set; }

    public int? RetryAttempts { get; set; }
}
