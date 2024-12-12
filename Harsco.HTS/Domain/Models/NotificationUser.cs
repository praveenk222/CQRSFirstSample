using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class NotificationUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public virtual ICollection<AdministrativeNotification> AdministrativeNotifications { get; set; } = new List<AdministrativeNotification>();

    public virtual ICollection<NotificationManager> NotificationManagers { get; set; } = new List<NotificationManager>();
}
