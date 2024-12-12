using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class FdModule
{
    public int Id { get; set; }

    public int CaptionId { get; set; }

    public string? ModuleName { get; set; }

    public short? MainMenuId { get; set; }

    public byte? ModuleType { get; set; }

    public string FacilityCode { get; set; } = null!;

    public virtual FdCaption Caption { get; set; } = null!;

    public virtual ICollection<FdForm> FdForms { get; set; } = new List<FdForm>();
}
