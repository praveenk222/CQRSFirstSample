using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FdMainMenu
{
    public short Id { get; set; }

    public string? MenuName { get; set; }

    public int? CaptionId { get; set; }

    public short? ParentId { get; set; }

    public string? MenuDescription { get; set; }

    public int? InvokeId { get; set; }

    public int? ToolTipId { get; set; }

    public string? ShortcutKeys { get; set; }

    public string? MenuIconPath { get; set; }

    public int? InvokeTypeIdentifier { get; set; }

    public bool? IsEmrd { get; set; }

    public string? MenuIconFileName { get; set; }

    public bool? IsFullScreen { get; set; }

    public int? IconId { get; set; }

    public bool? IsActive { get; set; }

    public string FacilityCode { get; set; } = null!;

    public virtual FdCaption? Caption { get; set; }

    public virtual ICollection<FdMainMenu> InverseParent { get; set; } = new List<FdMainMenu>();

    public virtual FdForm? Invoke { get; set; }

    public virtual RdReport? InvokeNavigation { get; set; }

    public virtual FdMainMenu? Parent { get; set; }

    public virtual MessageMaster? ToolTip { get; set; }
}
