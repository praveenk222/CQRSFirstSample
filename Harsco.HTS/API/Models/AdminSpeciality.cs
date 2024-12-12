using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AdminSpeciality
{
    public int SpecialityId { get; set; }

    public string Code { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual AdminUser? CreatedByNavigation { get; set; }

    public virtual AdminUser? LastModifiedByNavigation { get; set; }
}
