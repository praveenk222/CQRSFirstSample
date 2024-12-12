using System;
using System.Collections.Generic;

namespace API.Models;

public partial class NotificationTemplate
{
    public Guid TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string TemplateContent { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<NotificationManager> NotificationManagers { get; set; } = new List<NotificationManager>();
}
