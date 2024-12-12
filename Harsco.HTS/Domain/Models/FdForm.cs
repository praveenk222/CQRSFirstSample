using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class FdForm
{
    public int Id { get; set; }

    public int ModuleId { get; set; }

    public int CaptionId { get; set; }

    public string? FormName { get; set; }

    public byte? FormType { get; set; }

    public string? FdxFileName { get; set; }

    public string FacilityCode { get; set; } = null!;

    public virtual FdCaption Caption { get; set; } = null!;

    public virtual ICollection<FdMainMenu> FdMainMenus { get; set; } = new List<FdMainMenu>();

    public virtual FdModule Module { get; set; } = null!;
}
