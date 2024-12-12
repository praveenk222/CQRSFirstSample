using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class AdministrativeNotification
{
    public int NotificationId { get; set; }

    public string NotificationType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int RecipientId { get; set; }

    public string Sender { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? SentDate { get; set; }

    public DateTime? AcknowledgedDate { get; set; }

    public bool? IsUrgent { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public virtual NotificationUser Recipient { get; set; } = null!;
}
