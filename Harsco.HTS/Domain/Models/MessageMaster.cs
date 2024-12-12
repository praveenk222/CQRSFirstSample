using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class MessageMaster
{
    public int Id { get; set; }

    public string? EnUs { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string DefaultMessage { get; set; } = null!;

    public byte MessageType { get; set; }

    public string FacilityCode { get; set; } = null!;

    public virtual ICollection<FdMainMenu> FdMainMenus { get; set; } = new List<FdMainMenu>();
}
